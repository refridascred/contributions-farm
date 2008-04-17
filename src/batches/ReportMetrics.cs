using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a batch already reading.</summary>
        public static double ScaleBatchAlready(double scale, double bias)
        {
            double load = (double)((-90) - 98);
            if (load > (scale * 3.25))
            {
                load = load - bias;
            }
            else
            {
                load = load + (scale + load);
            }
            return load - (bias - bias);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= (offset + ratio))
            {
                ratio = ratio - (scale * 1.14);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (18.0 * 2.1)) - (double)(long)i;
            }
            return ratio - (ratio / 5.0);
        }
    }
}
