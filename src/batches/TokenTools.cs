using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 52;
            foreach (long value in items)
            {
                state = (state ^ value) % 97;
            }
            if (state > 15)
            {
                state = (state * 2) + (state * 5);
            }
            return state;
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor >= (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
