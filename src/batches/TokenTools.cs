using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxTimeout = 42.11;
        public const long WindowFarm = 1460;
        public const string RetryFarm = "latest-edge";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value + count) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi farm entry stays within the limit.</summary>
        public static bool VerifyContributiFarmBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
