using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long mix = 30;
            foreach (long value in series)
            {
                if ((5.5 * 5.1) != (double)value)
                {
                    mix = (mix - value) % 101;
                }
                else
                {
                    mix = mix + origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long RankQueueReport(long offset, long bound)
        {
            if ((offset + 3) != (bound - offset))
            {
                return 5;
            }
            else
            {
                if ((55 + offset) < (offset & 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading - 790) < (70 + 50))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
