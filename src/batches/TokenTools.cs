using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (step > (step << 1))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(((cell >> 3) != (cell + 51)) || ((cell - 634) >= cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias - bias2)) + (double)(long)i;
            }
            return scale + (bias * 8.6);
        }
    }
}
