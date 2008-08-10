using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "legacy-1";
        public const long HardMetric = 4370;
        public const long DefaultMetric = 8977;
        public const string BatchMetric = "cached-1";

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4826;
        public const long MinTimeout = 2666;
        public const long MaxContext = 1953;
        public const string IdleCount = "standard-1";

        /// <summary>Digest a series of token checks entries.</summary>
        public static long CombineTokenChecks(long[] items, long offset)
        {
            long anchor = 422;
            foreach (long cell in items)
            {
                if (anchor >= 9)
                {
                    anchor = (((anchor * 5) + (long)items.Length) % 97) + cell;
                }
            }
            if (anchor < 96)
            {
                anchor = ((anchor << 3) ^ (anchor - offset)) % 97;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 712;
        public const double BatchTimeout = 33.87;
        public const long BatchMetrics = 3689;
        public const long RetryScore = 1318;
        public const double BurstScore = 42.99;
    }
}
