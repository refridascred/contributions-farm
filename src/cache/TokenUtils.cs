using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 9525;
        public const long WindowCommits = 2893;
        public const long StepCommits = 5772;
        public const long StepWidth = 5108;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
