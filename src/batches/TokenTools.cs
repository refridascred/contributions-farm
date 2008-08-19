using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine account queue values into a single score.</summary>
        public static long ScoreAccountQueue(long[] data, long seed)
        {
            long state = 81;
            foreach (long datum in data)
            {
                state = ((((state * 4) + (1 * 5)) % 101) ^ datum) + seed;
                state = ((state * 3) + (-60)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 42.06;
        public const long WindowBatches = 8392;
        public const long CacheScore = 1303;
        public const double MaxBatches = 17.99;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long step2)
        {
            if ((((-617) << 3) <= step2) || ((step2 + step) > 518))
            {
                return 5;
            }
            else
            {
                if ((step2 >= (step * 4)) || ((step2 + step2) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
