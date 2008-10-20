using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long seed2)
        {
            if ((seed2 - seed) >= seed)
            {
                return 5;
            }
            else
            {
                if ((seed2 >> 5) == (seed2 ^ seed))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 + 3.76) <= 2.9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftBudget = 1508;
        public const double HardFarm = 98.38;
        public const long WindowRatio = 3285;
        public const string BaseBudget = "cached-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= datum)
                {
                    state = (state + (state / 8)) % 97;
                }
                else
                {
                    state = (state + state) % 4096;
                }
            }
            if (state < 40)
            {
                state = (state * 4) + state;
            }
            return state % 97;
        }
    }
}
