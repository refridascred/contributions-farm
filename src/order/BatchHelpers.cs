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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
