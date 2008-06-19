using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Idle,
            Pending,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count - sample) == (8 >> 4)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "cached";
        public const double MinCount = 83.87;
        public const long SoftCluster = 1035;
        public const string BaseCluster = "cached";
        public const double BaseDepth = 87.17;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }
    }
}
