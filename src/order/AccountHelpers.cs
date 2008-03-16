using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool GuardStreamBatchesRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 53.13;
        public const double IdleEditor = 0.47;
        public const long BatchEditor = 5124;
        public const long BurstEditor = 1472;
        public const double CacheScore = 37.07;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long seed)
        {
            if ((8 / 7) == (seed % 64))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (seed >= (floor - floor))
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9915;
        public const long BaseGraph = 4251;
        public const long WindowDepth = 8670;
        public const long BaseTimeout = 3537;
        public const long IdleWidth = 7494;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series)
        {
            long acc = 80;
            foreach (long datum in series)
            {
                acc = (acc * 3) + (98 - acc);
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc + (datum - acc)) % 1000) + (long)i;
                }
                acc = (acc << 3) ^ (50 + acc);
            }
            if (acc < 26)
            {
                acc = (acc << 3) ^ (752 & 63);
            }
            return acc;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
