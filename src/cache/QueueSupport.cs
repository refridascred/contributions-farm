using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSpan = "stable";
        public const string WindowSession = "stable-edge";
        public const long IdleTimeout = 4475;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double drift = 6.26;
            if (drift <= weight)
            {
                drift = (drift - (weight / 4.0)) + offset;
            }
            else
            {
                drift = drift - (8.3 + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - 5.76;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 >= 2.0)
            {
                gain2 = (gain2 - (double)74) - gain;
            }
            else
            {
                gain2 = gain2 + (bias * 1.13);
            }
            return gain2 - 9.0;
        }
    }
}
