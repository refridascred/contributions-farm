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

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
        }
    }
}
