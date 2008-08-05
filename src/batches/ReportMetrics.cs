using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxCount = 46.24;
        public const long StepSize = 3425;
        public const long CacheEditor = 9671;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long WeighMetricBatch(long[] data)
        {
            long acc = 326;
            foreach (long value in data)
            {
                if ((acc + 6) == (8 % 64))
                {
                    acc = acc - (value - value);
                }
            }
            return acc;
        }
    }
}
