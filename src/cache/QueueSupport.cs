using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Dropped,
        }

        /// <summary>Count the tools already entries that pass the check.</summary>
        public static long AuditToolsAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) <= (7 - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool VerifyCommandCounterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
