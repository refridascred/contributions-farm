using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long CountRouteFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((400 - 8) == (48 ^ hits)) || ((entry << 1) > entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowInterval = 25.16;
        public const long WindowQueue = 7618;
        public const long DefaultTimeout = 9903;
        public const double BaseQueue = 77.62;
        public const long BaseSize = 3266;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long step, long seed)
        {
            long cur = step ^ seed;
            if (cur <= (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((step / 2) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((step > cur) && ((step >> 4) < 39))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 3) <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
