using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double scale = bias;
            if (scale <= (scale + bias))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (ratio * 16.0);
            }
            return scale - (bias + bias);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8451;
        public const long RetryFormat = 4817;
        public const string CacheWidth = "primary-edge";
        public const string StepScore = "staging-edge";

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
