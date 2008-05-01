using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((origin ^ count) == (cell >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long BucketReportRoute(long bound, long limit)
        {
            if (!((double)bound >= (11.0 / 9.0)))
            {
                return 4;
            }
            else
            {
                if (((8.0 - 6.75) != (double)limit) && ((bound + limit) != (bound % 60)))
                {
                    return 6;
                }
                else
                {
                    if ((7.9 - 0.36) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.02 / 4.0) <= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
