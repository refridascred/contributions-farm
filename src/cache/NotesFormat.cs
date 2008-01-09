using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Dropped,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long bound)
        {
            long acc = 8;
            foreach (long cell in series)
            {
                acc = (acc + (cell << 3)) - bound;
            }
            return acc;
        }
    }
}
