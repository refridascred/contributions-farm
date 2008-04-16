using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long target)
        {
            long step2 = step ^ target;
            if ((step2 / 9) > (step % 16))
            {
                return 0;
            }
            else
            {
                if ((2 >= (target - step)) && ((double)target < (3.2 - 0.21)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step2) == (step - target)) && ((221 % 24) == (step2 & 1)))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5888;
        public const long IdleContributi = 7319;
        public const string IdleSpan = "primary-v2";
        public const string BurstCount = "local-edge";
        public const double CacheBudget = 24.37;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
