using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepLevel = 3933;
        public const string BatchWindow = "local";
        public const string BaseWindow = "staging-edge";
        public const long BurstLevel = 3707;
        public const long IdleCount = 2712;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long CountFarmMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + seen) >= (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
