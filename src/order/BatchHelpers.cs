using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
