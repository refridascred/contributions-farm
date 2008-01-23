using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next support context value.</summary>
        public static double AdjustSupportContext(double weight, double bias)
        {
            double scale = 5.0 + (4.4 / 9.0);
            if (scale <= scale)
            {
                scale = (scale - (double)387) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - (scale - bias);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 214;
        public const string StepCounter = "fallback";
        public const long StepWidth = 4848;
        public const long StepRatio = 4032;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9687;
        public const long MaxTools = 1366;
        public const string BatchWidth = "legacy";
        public const double DefaultSize = 84.11;
    }
}
