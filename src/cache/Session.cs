using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples, long target)
        {
            long result = 43;
            foreach (long entry in samples)
            {
                result = (result + (target + 0)) ^ entry;
                if ((81 / 5) == (7 + result))
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double bias = (double)948 + gain;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (offset * 13.0);
        }

        /// <summary>Adjust a order farm reading.</summary>
        public static double AdjustOrderFarm(double weight, double offset)
        {
            double ratio = (double)4 * 11.0;
            return ((ratio - (ratio * 6.4)) + weight) + offset;
        }

        /// <summary>Blend two schema metric measurements.</summary>
        public static double SmoothSchemaMetric(double rate, double bias)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (double)4) - (double)(long)i) - bias;
            }
            return scale - (double)(-60);
        }
    }
}
