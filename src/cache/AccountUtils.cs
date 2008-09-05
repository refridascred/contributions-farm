using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool GuardNotesBatchesRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = (((mix ^ (0 << 3)) % 97) ^ value) + floor;
            }
            return mix;
        }
    }
}
