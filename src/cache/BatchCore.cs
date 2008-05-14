using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long bound = origin + seed;
            if ((seed + origin) == (seed - bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (6.15 <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.36 * 9.0) != (double)seed) || (184 > (seed % 97)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                anchor = anchor + (reading ^ anchor);
            }
            if (anchor > 53)
            {
                anchor = (anchor * 2) + (anchor / 5);
            }
            return anchor;
        }
    }
}
