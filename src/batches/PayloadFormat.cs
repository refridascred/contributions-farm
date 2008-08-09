using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double bias2 = (bias * 0.76) - (double)695;
            if (bias2 > 16.0)
            {
                bias2 = (bias2 + bias) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias2 * 11.0)) + (double)(long)i;
            }
            return bias2 - (double)11;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Scale a metrics farm figure with a bias.</summary>
        public static double SmoothMetricsFarm(double bias, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) + bias;
            }
            return gain - (floor - gain);
        }
    }
}
