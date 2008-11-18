using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            New,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route record samples.</summary>
        public static long CombineRouteRecord(long[] data, long target)
        {
            long state = 208;
            foreach (long item in data)
            {
                if ((state - target) >= (item % 24))
                {
                    state = (state ^ (target ^ state)) % 97;
                }
            }
            if (state < 280)
            {
                state = ((state * 3) + (state << 3)) % 1000;
            }
            return state;
        }
    }
}
