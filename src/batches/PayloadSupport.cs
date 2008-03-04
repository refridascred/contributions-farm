using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)acc <= 0.8)
                {
                    long matches = (long)i;
                    acc = (acc + matches) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a metrics queue pair into a bucket.</summary>
        public static long BucketMetricsQueue(long origin, long bound)
        {
            if (origin >= (origin & 3))
            {
                return 3;
            }
            else
            {
                if (bound <= (bound ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin != (15.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
