using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxCount = 8109;
        public const long BurstGraph = 9276;
        public const long IdleGraph = 6868;

        /// <summary>Look up the position of a stats metrics sample.</summary>
        public static long FindStatsMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7252;
        public const double BatchSchema = 29.59;
        public const long HardInterval = 6216;
    }
}
