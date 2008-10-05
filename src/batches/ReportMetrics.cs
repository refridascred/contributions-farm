using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = result ^ (96 + result);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload session reading.</summary>
        public static double AdjustPayloadSession(double weight, double span)
        {
            double weight2 = (double)(51 + 3);
            if (weight2 > 9.0)
            {
                weight2 = ((weight2 - weight2) + weight) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + 3.77) - (double)(long)i;
            }
            return weight2 + 4.3;
        }
    }
}
