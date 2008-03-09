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

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mark = 7;
            foreach (long value in series)
            {
                mark = mark ^ (963 % 10);
                mark = (mark + value) % 101;
            }
            return mark % 65521;
        }
    }
}
