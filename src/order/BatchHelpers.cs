using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSpan = 6326;
        public const long BurstCommits = 8871;
        public const long HardCommits = 4751;

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 8189;
        public const long WindowChecks = 698;
        public const long BatchChecks = 9294;
        public const long SoftChecks = 787;
    }
}
