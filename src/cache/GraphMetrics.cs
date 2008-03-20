using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = result - (bound % 64);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double gain = offset * 7.51;
            if (gain <= (scale - gain))
            {
                gain = gain + (7.21 / 9.0);
            }
            else
            {
                gain = gain + (double)2;
            }
            return gain - 8.3;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count / 7) < (cell & 3))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next queue context value.</summary>
        public static double AdjustQueueContext(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (scale2 - scale2))
            {
                scale2 = (scale2 + (double)24) - floor;
            }
            return scale2 - (double)(-50);
        }
    }
}
