using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count << 3) <= (count + (-548))) || ((2.0 / 3.0) >= (double)cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits + hits) == (value - hits)) && ((value ^ hits) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
