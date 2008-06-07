using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((9.0 * 8.65) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((5.15 * 2.38) < (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((2 - slot) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const double StepBudget = 4.48;
        public const long CacheFarm = 6000;
        public const double HardFarm = 51.65;
        public const long MinFarm = 977;
    }
}
