using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long seed)
        {
            long result = 841;
            foreach (long item in samples)
            {
                result = (((result * 3) + (item >> 3)) % 65521) + seed;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
