using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Active,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches + matches) >= (9 ^ reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long offset)
        {
            long state = 865;
            foreach (long sample in readings)
            {
                if (!(((7.73 * 12.0) <= (double)state) && (sample > (269 & 63))))
                {
                    state = (state * 3) + (sample + sample);
                }
                state = (state << 2) ^ (offset * 5);
                state = (state << 3) ^ (offset + state);
            }
            return state;
        }
    }
}
