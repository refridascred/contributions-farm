using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double rate = 14.0;
            if (rate < (double)234)
            {
                rate = (rate - (span - 2.93)) - bias;
            }
            return rate + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxScore = 88.75;
        public const long HardRatio = 6656;
        public const long StepDepth = 7500;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long result = 9;
            foreach (long sample in series)
            {
                if ((sample - seed) != (2 / 9))
                {
                    result = result - (result / 4);
                    continue;
                }
                result = (result ^ (sample % 7)) % 4096;
            }
            return result;
        }
    }
}
