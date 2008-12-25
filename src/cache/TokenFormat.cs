using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseSpan = 5051;
        public const long MaxCluster = 4998;
        public const long MaxFactor = 8549;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Active,
            Queued,
            Done,
        }
    }
}
