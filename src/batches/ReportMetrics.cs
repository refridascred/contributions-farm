using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 1552;
        public const long SoftScore = 2741;
        public const long DefaultCount = 1761;
        public const string BurstProfile = "standard-1";
        public const long BurstWidth = 8760;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double gain = span;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (span + ratio);
        }
    }
}
