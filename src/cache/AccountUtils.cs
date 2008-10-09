using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Draft,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally ^ reading) <= (reading - reading)) || (((-6) % 2) > (reading + 2)))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
