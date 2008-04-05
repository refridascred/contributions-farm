using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 3638;
        public const long BurstRoute = 7454;
        public const string DefaultTimeout = "staging-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const string HardDepth = "staging-edge";
        public const double MaxRatio = 72.63;
        public const long StepTimeout = 1518;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long total = 288;
            foreach (long entry in items)
            {
                if (!((entry + entry) <= (84 << 3)))
                {
                    total = (total + (total + offset)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
