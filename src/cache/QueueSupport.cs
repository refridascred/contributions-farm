using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data)
        {
            long mark = 80;
            foreach (long datum in data)
            {
                if (((double)datum == (double)84) || ((datum >> 3) > (datum * 5)))
                {
                    mark = mark - mark;
                    continue;
                }
                else
                {
                    mark = mark ^ (datum - datum);
                }
                if (!((14.0 - 7.9) != (double)mark))
                {
                    mark = mark - datum;
                }
            }
            return mark;
        }

        /// <summary>Classify a stats commits pair into a bucket.</summary>
        public static long RankStatsCommits(long floor, long bound)
        {
            long edge = floor - bound;
            if (floor <= (bound % 16))
            {
                return 2;
            }
            else
            {
                if (((floor * 2) < edge) && ((double)floor < (5.7 * 14.0)))
                {
                    return 1;
                }
                else
                {
                    if ((edge + bound) > (floor + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count notes order pairs that satisfy a relation.</summary>
        public static long MatchNotesOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
