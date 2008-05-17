using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9555;
        public const double WindowChecks = 13.66;
        public const long MaxFactor = 7526;

        /// <summary>Compare every pair of farm batches readings.</summary>
        public static long PairFarmBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long bound)
        {
            long slot = target - bound;
            if ((double)target == (20.0 / 4.0))
            {
                return 3;
            }
            else
            {
                if (((9.2 * 7.02) < (double)bound) && ((17.0 - 3.12) != (double)slot))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
