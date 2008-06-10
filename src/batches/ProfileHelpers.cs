using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "primary";
        public const string BatchWindow = "local-1";
        public const long SoftWindow = 8284;
        public const long MaxWindow = 2687;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((6.4 * 4.7) <= (double)offset)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 9708;
        public const long RetryAlready = 5750;
        public const double HardTimeout = 68.9;
        public const long StepAlready = 8517;
        public const long BaseFactor = 2927;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Active,
            Done,
            Dropped,
        }
    }
}
