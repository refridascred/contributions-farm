using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool CheckToolsLayoutLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
