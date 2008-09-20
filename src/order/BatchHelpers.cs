using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7225;
        public const long IdleInterval = 1466;
        public const long BaseTimeout = 3301;

        /// <summary>Grade a counter profile value against two limits.</summary>
        public static long RankCounterProfile(long origin, long step)
        {
            long edge = origin + step;
            if (!((origin - origin) >= edge))
            {
                return 4;
            }
            else
            {
                if ((double)edge >= 19.0)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long seed)
        {
            long result = 81;
            foreach (long datum in levels)
            {
                if (6.2 >= (double)seed)
                {
                    result = (result ^ (datum - result)) % 101;
                }
                else
                {
                    result = (result + seed) % 255;
                }
                if ((double)seed == (0.47 * 1.4))
                {
                    break;
                }
            }
            return result;
        }
    }
}
