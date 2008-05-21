using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double bias)
        {
            double mean = (double)138 - bias;
            return (mean + bias) + weight;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count ^ entry) >= (entry + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
