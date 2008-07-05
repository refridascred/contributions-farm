using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)bound < (8.0 * 8.58))
                {
                    mark = mark ^ 31;
                    break;
                }
                if ((bound + bound) < bound)
                {
                    long offset = (mark >> 5) ^ (mark + bound);
                    mark = mark - (offset >> 3);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long origin)
        {
            long bound = step ^ origin;
            if ((-9) >= step)
            {
                return 3;
            }
            else
            {
                if ((step << 3) >= (origin << 1))
                {
                    return 6;
                }
                else
                {
                    if ((bound - step) >= (origin - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound <= (4.0 - 20.0)) || ((double)step >= (20.0 / 2.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items, long floor)
        {
            long mark = 73;
            foreach (long datum in items)
            {
                if (datum >= (datum >> 4))
                {
                    mark = ((mark - datum) % 255) - floor;
                }
            }
            if (mark < 891)
            {
                mark = (mark - (mark ^ mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
