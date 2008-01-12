using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches % 5) == (matches + 337)) && ((12.0 * 4.02) >= (double)matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if ((offset2 * 5) <= (offset2 * 3))
            {
                return 5;
            }
            else
            {
                if (!((offset + offset) > 505))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 / 9) > (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
