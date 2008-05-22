using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples, long offset)
        {
            long total = 15;
            foreach (long reading in samples)
            {
                if ((offset + (-5)) == ((-7) % 97))
                {
                    total = total - (12 / 5);
                }
                if ((double)reading != (6.29 - 5.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long target)
        {
            long delta = limit - target;
            if ((limit - limit) < (limit - 108))
            {
                return 8;
            }
            else
            {
                if (!((double)541 > (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + delta) > (target % 3))
                    {
                        return 5;
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
