using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long origin)
        {
            if ((origin > (origin >> 1)) && ((double)origin <= (11.0 + 2.0)))
            {
                return 7;
            }
            else
            {
                if (((-19) / 3) > (origin << 1))
                {
                    return 6;
                }
                else
                {
                    if (2.29 < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-22) << 3) < origin) && (origin < (origin - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cluster format value against two limits.</summary>
        public static long RankClusterFormat(long seed, long floor)
        {
            if (((double)floor > (double)seed) || ((3 / 3) >= (seed + 63)))
            {
                return 0;
            }
            else
            {
                if (seed >= (97 + seed))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a tools format counter forward.</summary>
        public static long DeriveToolsFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (((mark >> 2) >= (long)i) && ((59 + mark) >= mark))
                {
                    mark = (mark - (mark - mark)) % 1000;
                    mark = (mark - (step + step)) % 65521;
                }
                if (!((mark + mark) != (long)i))
                {
                    mark = mark ^ ((long)i % 24);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
