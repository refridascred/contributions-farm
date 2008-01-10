using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 86.07;
        public const long HardCount = 3731;
        public const long BaseReport = 9591;
        public const long HardBudget = 3567;
        public const long LimitSpan = 1798;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches > (9.5 / 2.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
