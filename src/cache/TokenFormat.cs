using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long mix = 3;
            foreach (long item in data)
            {
                mix = (((mix << 2) ^ mix) % 97) + item;
            }
            if (mix < 65)
            {
                mix = ((mix * 3) + step) % 255;
            }
            return mix;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long target, long origin)
        {
            long edge = target - origin;
            if ((double)target != (0.53 - 1.85))
            {
                return 1;
            }
            else
            {
                if ((target - origin) > (271 + edge))
                {
                    return 8;
                }
                else
                {
                    if (!((target + target) > edge))
                    {
                        return 0;
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
