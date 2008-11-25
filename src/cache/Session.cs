using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long state = 93;
            foreach (long entry in levels)
            {
                if (((double)entry < (3.0 - 17.0)) && ((35 * 2) < (entry << 3)))
                {
                    state = state - (1 % 16);
                }
                else
                {
                    state = ((state << 3) ^ (entry + offset)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((14.0 + 2.2) != (double)origin)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
