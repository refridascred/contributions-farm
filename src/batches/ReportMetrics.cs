using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheDepth = 2656;
        public const long HardFactor = 7349;
        public const long BatchTools = 4083;
        public const long BaseTools = 2151;

        /// <summary>Project the next queue buffer value.</summary>
        public static double ProjectQueueBuffer(double rate, double span)
        {
            double gain = span - span;
            if (gain > 6.9)
            {
                gain = (gain + gain) - rate;
            }
            return gain + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxScore = "cached-v2";
        public const string HardEntry = "strict-v2";
        public const string HardWidth = "local-v2";
    }
}
