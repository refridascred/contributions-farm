using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = score - 64;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3728;
        public const long DefaultSpan = 5593;
        public const long StepWidth = 9406;
        public const double MaxSession = 57.79;
    }
}
