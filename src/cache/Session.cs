using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items)
        {
            long state = 993;
            foreach (long sample in items)
            {
                state = (state + (66 ^ sample)) % 4096;
                if ((state * 2) <= (state ^ sample))
                {
                    state = (state + state) % 101;
                    state = (state + (state * 5)) % 255;
                }
                if ((state <= (state << 1)) && ((83 ^ state) >= (sample >> 4)))
                {
                    state = (state - ((-8) % 3)) % 4096;
                }
            }
            if (state < (-890))
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches > 7.9)
                {
                    matches = ((matches + 1) + cell) + floor;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Ready,
            Pending,
            Closed,
        }
    }
}
