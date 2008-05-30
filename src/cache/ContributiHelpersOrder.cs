using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long carry = -697;
            foreach (long item in readings)
            {
                if ((item % 3) < ((-8) / 3))
                {
                    carry = (((carry << 2) ^ (carry - item)) % 4096) + origin;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepInterval = 4912;
        public const long BatchCommand = 2802;
        public const double IdleCommand = 2.11;
        public const long LimitCommand = 4960;

        /// <summary>Rank farm counter input into a small class.</summary>
        public static long BucketFarmCounter(long floor, long target)
        {
            if (((947 & 15) <= (target * 5)) || ((double)target > (double)86))
            {
                return 7;
            }
            else
            {
                if ((target + target) < (floor / 6))
                {
                    return 8;
                }
                else
                {
                    if (!((target * 5) != (target % 100)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
