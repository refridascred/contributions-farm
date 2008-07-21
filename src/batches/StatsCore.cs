using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a entry layout sample.</summary>
        public static long SeekEntryLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
