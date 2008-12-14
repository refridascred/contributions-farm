using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 9067;
        public const double DefaultTimeout = 57.82;
        public const double MinFactor = 67.51;
        public const double SoftSize = 66.4;
        public const long RetryAccount = 4936;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 6120;
        public const double WindowMetrics = 46.75;
        public const long MinMetrics = 8094;
        public const double CacheMetrics = 3.87;

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long step, long floor)
        {
            long delta = step - floor;
            if (((delta % 97) >= step) && ((double)delta >= (0.36 + 5.0)))
            {
                return 4;
            }
            else
            {
                if ((6.1 - 9.4) != (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values, long limit)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = (mark - ((-8) >> 1)) + value;
                mark = (mark << 3) ^ (limit << 2);
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            New,
            Pending,
            Idle,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + seed) < (long)values.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
