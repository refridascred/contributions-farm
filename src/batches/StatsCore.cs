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

        /// <summary>Find the first stats editor entry that matches the target.</summary>
        public static long SeekStatsEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long offset)
        {
            if (((offset << 2) < (135 ^ (-789))) && (55 <= floor))
            {
                return 2;
            }
            else
            {
                if (offset <= (floor + offset))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 4.12;
        public const long LimitWidth = 793;
        public const long BaseScore = 2483;
        public const double WindowInterval = 65.59;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long total = 25;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ (33 + total)) - entry;
                total = ((total * 5) + origin) % 65521;
            }
            return total % 1000;
        }
    }
}
