using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)target >= (1.88 / 3.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
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

        /// <summary>Derive the next notes format value from a seed.</summary>
        public static long RollNotesFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((target + target) == (anchor - (long)i)))
                {
                    anchor = anchor - (target ^ anchor);
                    anchor = ((anchor << 3) ^ (target * 3)) % 101;
                }
                anchor = (anchor + target) % 4096;
                anchor = anchor - (target ^ (long)i);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
