using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 753;
        public const double BaseMetrics = 54.13;
        public const long StepMetrics = 7325;
        public const string WindowWidth = "standard-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchSpan = "staging-v2";
        public const long SoftScore = 2398;
        public const long StepDepth = 8400;
        public const long CacheNotes = 4093;
        public const string WindowNotes = "primary-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry - (value ^ carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
