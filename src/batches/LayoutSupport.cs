using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((double)cell <= (1.58 - 19.0)) && (640 > (hits % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks tools reading by value.</summary>
        public static long FindChecksToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((746 & 7) != (tally + datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if (((-8) & 15) >= floor)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) < (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long bound)
        {
            if ((156 ^ bound) <= (bound % 16))
            {
                return 0;
            }
            else
            {
                if ((step + bound) < (96 + bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound < (7.78 / 7.0))
                        {
                            return 2;
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
}
