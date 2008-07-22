using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) == (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue metric measurements.</summary>
        public static double AdjustQueueMetric(double scale, double bias)
        {
            double ratio = (bias + bias) - (14.0 + bias);
            if (ratio <= (bias + bias))
            {
                ratio = (ratio - 2.0) - scale;
            }
            return ratio + (1.7 - ratio);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double offset)
        {
            double load = (double)413 + (6.0 - gain);
            if (load > (8.86 / 7.0))
            {
                load = (load + (double)578) - offset;
            }
            return load + (double)102;
        }
    }
}
