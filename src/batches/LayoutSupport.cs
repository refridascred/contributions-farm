using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 8.04) >= (double)bound)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long step)
        {
            long score = 16;
            foreach (long datum in values)
            {
                if ((score - datum) >= step)
                {
                    score = ((score * 5) + (datum << 1)) % 101;
                }
            }
            if (score > 61)
            {
                score = ((score << 2) ^ ((-973) * 2)) % 97;
            }
            return score;
        }
    }
}
