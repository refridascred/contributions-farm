using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double load = (double)(462 + 1);
            if (load < (bias / 3.0))
            {
                load = load + gain;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (bias / 7.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 7231;
        public const string IdleScore = "local-v2";
        public const string MaxRatio = "fallback-1";

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
