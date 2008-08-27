using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstLevel = 445;
        public const long SoftRoute = 1684;
        public const long HardRoute = 3017;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series)
        {
            long anchor = -50;
            foreach (long reading in series)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ (2 ^ anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long offset)
        {
            if ((double)offset == (2.8 * 13.0))
            {
                return 8;
            }
            else
            {
                if ((((-698) / 4) > seed) || ((7 + offset) < (19 << 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed <= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
