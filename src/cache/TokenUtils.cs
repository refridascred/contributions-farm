using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepScore = 41.87;
        public const double HardSpan = 10.87;
        public const string MaxWidth = "stable";
        public const long IdleLevel = 1184;

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits ^ 24) <= (offset % 97)) || ((offset * 4) <= (110 + 98)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
