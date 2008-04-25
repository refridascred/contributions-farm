using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2934;
        public const long BurstTimeout = 9393;
        public const long MaxInterval = 141;
        public const long SoftCount = 8251;
        public const double HardFarm = 41.64;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally % 64) > (tally - step)) || (step < tally))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (floor >= (floor + (-8)))
            {
                return 8;
            }
            else
            {
                if (!((floor - seed) < 18))
                {
                    return 2;
                }
                else
                {
                    if ((slot < (3 - slot)) || ((double)slot >= 0.3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
