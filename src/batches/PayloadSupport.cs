using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
