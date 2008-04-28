using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank record commits input into a small class.</summary>
        public static long BucketRecordCommits(long target, long origin)
        {
            if ((double)origin <= (5.1 + 5.67))
            {
                return 1;
            }
            else
            {
                if ((target << 3) != (origin % 12))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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
