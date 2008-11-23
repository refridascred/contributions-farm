using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double floor)
        {
            double ratio = (double)259;
            if (ratio >= floor)
            {
                ratio = ratio - (double)576;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - 1.64;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double offset)
        {
            double mean = scale + (offset - 8.9);
            if (mean < 0.2)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - (double)39;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - (scale * 3.86);
        }
    }
}
