using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long limit)
        {
            if ((seed >= (seed + (-7))) && (limit > (limit % 7)))
            {
                return 1;
            }
            else
            {
                if ((seed & 63) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= (limit % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + limit) < (seed & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 3855;
        public const double HardQueue = 98.88;
        public const long BurstQueue = 3528;
        public const long DefaultSize = 1279;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 45.14;
        public const string WindowCounter = "primary-1";
        public const long StepCounter = 5296;
        public const long BaseRatio = 8704;
    }
}
