using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 6677;
        public const long LimitFactor = 3916;
        public const long StepSize = 3287;
        public const long MinWidth = 6996;
        public const long MinInterval = 5781;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
