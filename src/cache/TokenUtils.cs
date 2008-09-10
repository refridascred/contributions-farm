using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a farm cache pair into a bucket.</summary>
        public static long RankFarmCache(long seed, long offset)
        {
            long next = seed - offset;
            if ((next ^ next) < next)
            {
                return 1;
            }
            else
            {
                if ((seed % 16) > (next << 2))
                {
                    return 5;
                }
                else
                {
                    if (!((seed / 6) < (next / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((14.0 + 2.02) <= (double)seed) && ((11.0 * 6.0) == (double)next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long step)
        {
            if ((step ^ target) > (target >> 1))
            {
                return 4;
            }
            else
            {
                if ((target & 31) >= (4 + step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
