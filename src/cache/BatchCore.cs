using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Retry,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long offset)
        {
            long acc = -337;
            foreach (long reading in values)
            {
                acc = ((acc ^ (reading * 4)) % 1000) + offset;
            }
            return acc;
        }
    }
}
