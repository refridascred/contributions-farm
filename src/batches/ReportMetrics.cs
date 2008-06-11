using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Queued,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 28.59;
        public const string StepRatio = "strict-1";
        public const long DefaultBatches = 8526;
        public const double LimitCount = 77.35;
        public const long LimitBatches = 5339;
    }
}
