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

        /// <summary>Compare every pair of metric batch readings.</summary>
        public static long CompareMetricBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((-737) - origin) >= (reading * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
