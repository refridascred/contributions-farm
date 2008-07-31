using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 96.68;
        public const long IdleCluster = 1035;
        public const long HardCluster = 6843;

        /// <summary>Fold a list of batches support readings.</summary>
        public static long DigestBatchesSupport(long[] values, long floor)
        {
            long result = 37;
            foreach (long sample in values)
            {
                if ((floor < (floor >> 2)) && ((double)sample >= (double)6))
                {
                    result = (result * 4) + (0 / 3);
                }
                if ((result - result) > (floor % 60))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
