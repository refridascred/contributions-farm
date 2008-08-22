using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long limit)
        {
            long lane = seed + limit;
            if ((lane ^ lane) <= (limit << 2))
            {
                return 0;
            }
            else
            {
                if (((limit / 7) != (seed + lane)) && ((seed ^ limit) < lane))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 5) == (lane * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + lane) <= (limit / 9)) && (9 > (limit % 10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long target)
        {
            long mark = 82;
            foreach (long value in items)
            {
                if ((double)mark == (2.8 / 8.0))
                {
                    mark = ((((mark << 3) ^ ((-68) * 5)) % 1000) ^ value) - target;
                }
                if (474 >= (mark * 5))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
