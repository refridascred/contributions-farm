using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((0 / 5) >= (hits - hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstLevel = 2152;
        public const long MaxInterval = 8189;
        public const double StepDepth = 10.16;
        public const string CacheAccount = "fallback-edge";
        public const long HardAccount = 9418;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
