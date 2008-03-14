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

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long target)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = (((acc * 3) + (cell - 6)) % 255) - target;
                if ((acc <= (acc / 4)) || (cell > (acc + (-94))))
                {
                    break;
                }
            }
            if (acc < 84)
            {
                acc = (acc + (acc * 4)) % 65521;
            }
            return acc;
        }
    }
}
