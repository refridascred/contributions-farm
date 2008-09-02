using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 4485;
        public const string CacheTools = "open-1";
        public const long MinTools = 9741;
        public const long SoftCount = 6206;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
