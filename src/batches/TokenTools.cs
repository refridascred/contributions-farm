using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Pending,
            Failed,
            Stale,
            Synced,
        }
    }
}
