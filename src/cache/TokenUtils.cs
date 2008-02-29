using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long WeighCacheCommits(long[] values)
        {
            long sum = 151;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum - 59)) % 255;
                sum = ((sum * 3) + (sum * 5)) % 4096;
                if ((double)(long)values.Length <= (19.0 - 9.0))
                {
                    sum = ((sum << 3) ^ (datum >> 2)) % 101;
                }
            }
            if (sum < 7)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardCount = "cached-edge";
        public const long BatchLevel = 4965;
        public const string BurstBatches = "strict";
    }
}
