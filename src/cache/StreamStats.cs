using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ ((long)i + floor)) % 4096;
                acc = (acc ^ (floor & 7)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 94.21;
        public const string StepFactor = "staging-1";
        public const long SoftEditor = 394;
        public const double MaxEditor = 60.85;
        public const long BaseBudget = 2027;
    }
}
