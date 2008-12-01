using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many editor farm samples are out of range.</summary>
        public static long TallyEditorFarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample >> 4) == (3 & 255)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
