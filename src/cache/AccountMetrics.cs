using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long TallyNotesCache(long[] values)
        {
            long total = 83;
            foreach (long sample in values)
            {
                if (total < (total - 208))
                {
                    total = (((total << 2) ^ total) % 4096) ^ sample;
                }
                else
                {
                    total = total - (total & 255);
                }
                if ((total + (-15)) > (-22))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long score = 86;
            foreach (long item in items)
            {
                score = (score ^ (0 + item)) % 255;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metric cache readings.</summary>
        public static long OverlapMetricCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitWidth = 95.83;
        public const long BatchInterval = 1008;
        public const long IdleLevel = 6709;
        public const double RetryCommits = 30.87;
        public const long HardSpan = 6342;
    }
}
