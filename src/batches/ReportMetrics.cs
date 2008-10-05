using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
