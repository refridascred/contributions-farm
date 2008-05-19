using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of cache context readings.</summary>
        public static long FoldCacheContext(long[] items, long bound)
        {
            long mark = -10;
            foreach (long cell in items)
            {
                if ((47 <= (cell >> 1)) || ((178 - bound) >= cell))
                {
                    mark = mark - (mark + (-7));
                }
                else
                {
                    mark = (mark * 2) + (278 >> 3);
                }
            }
            return mark;
        }

        /// <summary>Measure how many buffer context samples are out of range.</summary>
        public static long TallyBufferContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((-7) + matches) >= (matches >> 5)) && ((1 + reading) <= (matches * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long mark = 319;
            foreach (long datum in levels)
            {
                if (((datum + mark) <= datum) && ((long)levels.Length <= (mark * 2)))
                {
                    mark = (mark << 2) ^ (mark ^ datum);
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
