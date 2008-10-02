using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3582;
        public const double SoftSize = 14.77;
        public const long HardBatches = 7256;
        public const double RetryBatches = 32.38;

        /// <summary>Find the first cluster support entry that matches the target.</summary>
        public static long LookupClusterSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
