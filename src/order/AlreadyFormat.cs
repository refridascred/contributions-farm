using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            New,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Iterate the support schema series from a seed.</summary>
        public static long RollSupportSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state + (162 - (long)i);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long origin)
        {
            long result = 67;
            foreach (long reading in levels)
            {
                result = ((result << 2) ^ (reading + 615)) - origin;
                result = (result ^ (9 << 1)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = (state + target) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
