using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2322;
        public const string StepWidth = "staging-edge";
        public const long DefaultSize = 6273;
        public const string BatchSize = "primary-1";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Stale,
            Closed,
            Active,
        }
    }
}
