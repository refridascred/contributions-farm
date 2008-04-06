using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((-72) <= offset))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series, long limit)
        {
            long sum = 339;
            foreach (long item in series)
            {
                sum = sum ^ (limit ^ item);
                sum = ((sum * 3) + item) % 4096;
            }
            if (sum < 32)
            {
                sum = ((sum << 3) ^ ((-180) ^ sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchScore = "standard-edge";
        public const long RetryWidth = 4439;
        public const long SoftDepth = 5927;
        public const string CacheCommits = "open-v2";
    }
}
