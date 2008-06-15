using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Locate a route cache reading by value.</summary>
        public static long LookupRouteCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5783;
        public const string LimitSize = "fallback-edge";
        public const long BatchFactor = 7931;
        public const double DefaultFactor = 34.85;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8121;
        public const long MinSpan = 4103;
        public const string StepCount = "staging-1";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Ready,
            Dropped,
            Stale,
            Draft,
        }
    }
}
