using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((step / 4) <= (0 >> 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
