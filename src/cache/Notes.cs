using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long target)
        {
            long bound = offset + target;
            if (((double)bound == (double)925) && ((offset - target) > ((-9) >> 5)))
            {
                return 0;
            }
            else
            {
                if (!((bound - bound) < target))
                {
                    return 7;
                }
                else
                {
                    if ((bound - offset) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long limit)
        {
            if ((double)limit != (double)offset)
            {
                return 8;
            }
            else
            {
                if (limit <= (limit + offset))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 4) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((double)907 <= (double)entry) && (((entry + tally) > tally) || (6.91 < (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long mark = 322;
            foreach (long cell in readings)
            {
                if ((0.6 - 5.3) <= (double)mark)
                {
                    mark = ((mark * 2) + (cell * 3)) % 97;
                    mark = (mark + (cell & 127)) % 65521;
                }
                else
                {
                    mark = mark ^ (long)readings.Length;
                }
                mark = ((mark << 3) ^ (origin - cell)) % 97;
            }
            if (mark > 925)
            {
                mark = ((mark * 5) + origin) % 1000;
            }
            return mark % 4096;
        }
    }
}
