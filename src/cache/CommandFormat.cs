using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 42.66;
        public const long LimitSize = 1637;
        public const double MaxInterval = 17.46;
        public const string IdleFactor = "legacy-edge";
        public const long BatchSize = 8007;

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
