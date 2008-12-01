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

        /// <summary>Fold a list of entry queue readings.</summary>
        public static long TallyEntryQueue(long[] values)
        {
            long total = 9;
            foreach (long value in values)
            {
                total = ((total << 3) ^ (value >> 2)) % 255;
            }
            if (total < 14)
            {
                total = (total + (total % 7)) % 255;
            }
            return total % 1000;
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
