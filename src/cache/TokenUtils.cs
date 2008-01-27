using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample < (sample >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (((double)edge > (double)floor) && ((double)edge >= (17.0 * 9.0)))
            {
                return 2;
            }
            else
            {
                if ((edge % 7) <= (46 % 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 5079;
        public const long IdleCommits = 4682;
        public const string BaseSpan = "latest-v2";
        public const long DefaultLevel = 102;
        public const long RetryCommits = 8786;
    }
}
