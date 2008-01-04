using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a context metric reading.</summary>
        public static double BlendContextMetric(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < scale2)
            {
                scale2 = scale2 - span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 - span;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
