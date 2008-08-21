using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Offset { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3103;
        public const double CacheDepth = 11.62;
        public const long DefaultDepth = 5174;
        public const double MinRecord = 63.17;

        /// <summary>Count the profile command entries that pass the check.</summary>
        public static long AuditProfileCommandOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value == (5.0 / 2.0))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Idle,
            Done,
        }
    }
}
