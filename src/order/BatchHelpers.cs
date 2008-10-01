using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Draft,
            New,
            Closed,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "cached-v2";
        public const long MinSize = 175;
        public const long MaxTimeout = 6343;
    }
}
