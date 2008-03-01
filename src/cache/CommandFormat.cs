using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long target)
        {
            long gap = step + target;
            if (!((target << 3) >= (gap ^ step)))
            {
                return 1;
            }
            else
            {
                if (!((double)step >= (7.1 * 7.72)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Done,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((double)matches > (2.21 + 12.0)))
                {
                    matches = ((matches + 1) + sample) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
