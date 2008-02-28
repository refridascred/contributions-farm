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

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double mean = (double)(888 + 462);
            if (mean >= ratio)
            {
                mean = (mean - ratio) - offset;
            }
            return mean + ratio;
        }
    }
}
