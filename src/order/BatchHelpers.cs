using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double mean = (bias - bias) - (bias * 16.0);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale * 2.0)) + (double)(long)i;
            }
            return mean - (double)35;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 6; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (bias + bias);
        }
    }
}
