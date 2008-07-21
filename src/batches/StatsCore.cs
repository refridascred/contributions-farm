using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (limit > (step & 63))
            {
                return 3;
            }
            else
            {
                if ((limit % 60) > (limit >> 2))
                {
                    return 1;
                }
                else
                {
                    if (3.03 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long MeasureRecordEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >= matches) || (2.3 <= (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values, long floor)
        {
            long state = 2;
            foreach (long value in values)
            {
                if ((double)value > 5.0)
                {
                    state = ((state * 5) + state) + floor;
                }
            }
            return state;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 4.12;
        public const long LimitWidth = 793;
        public const long BaseScore = 2483;
        public const double WindowInterval = 65.59;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long step)
        {
            if (bound >= (step / 9))
            {
                return 7;
            }
            else
            {
                if ((6 - step) == (step - bound))
                {
                    return 8;
                }
                else
                {
                    if ((8 / 2) == (step - bound))
                    {
                        return 1;
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
