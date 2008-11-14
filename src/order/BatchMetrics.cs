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

        /// <summary>Count the metrics contributi entries that pass the check.</summary>
        public static long AuditMetricsContributiMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally << 1) != (tally + entry)) && ((35 >> 4) < (86 + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxScore = 88.75;
        public const long HardRatio = 6656;
        public const long StepDepth = 7500;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8445;
        public const long DefaultDepth = 2192;
        public const double HardBudget = 29.04;
        public const long CacheContributi = 6217;

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
