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

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long MeasureSupportCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 7) >= (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
