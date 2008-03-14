using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a cache window reading.</summary>
        public static double ScaleCacheWindow(double weight, double floor)
        {
            double bias = 12.0;
            if (bias <= (double)54)
            {
                bias = (bias + weight) - floor;
            }
            return bias - (bias + bias);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ (entry - 20)) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (40 << 3)) % 101;
                if ((limit >= (long)i) || (((long)i * 3) >= limit))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
