using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitLevel = "strict-v2";
        public const long SoftRatio = 8832;
        public const string StepBudget = "latest-1";

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

        /// <summary>Accumulate contributi token samples.</summary>
        public static long DigestContributiToken(long[] samples, long limit)
        {
            long acc = -1;
            foreach (long item in samples)
            {
                acc = ((acc << 3) ^ (item - item)) - limit;
            }
            return acc % 4096;
        }
    }
}
