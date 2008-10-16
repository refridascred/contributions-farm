using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next token editor value.</summary>
        public static double AdjustTokenEditor(double scale, double bias)
        {
            double scale2 = 8.8;
            if (scale2 < (19.0 * 12.0))
            {
                scale2 = (scale2 - 4.08) - bias;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowCount = "fallback-1";
        public const long SoftFactor = 2539;
        public const long IdleAccount = 6873;
        public const double StepTimeout = 90.51;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 6831;
        public const long CacheTimeout = 4793;
        public const double BurstTimeout = 51.07;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
