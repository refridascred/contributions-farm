using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long score = 64;
            foreach (long item in values)
            {
                score = ((score ^ (item - score)) % 255) - step;
            }
            if (score < 3)
            {
                score = ((score * 2) + (score >> 1)) % 101;
            }
            return score;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            if ((floor ^ bound) != (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) == (985 % 12))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Count the counter metric entries that pass the check.</summary>
        public static long MeasureCounterMetricMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            New,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 255;
                if ((reading * 2) > (103 ^ limit))
                {
                    anchor = (anchor + (limit - limit)) % 4096;
                }
                if (limit > reading)
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor * 3) + (anchor * 2);
            }
            return anchor;
        }
    }
}
