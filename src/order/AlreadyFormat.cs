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

        /// <summary>Measure how many batches entry samples are out of range.</summary>
        public static long CountBatchesEntryMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((bound + 0) > (bound / 9))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
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
