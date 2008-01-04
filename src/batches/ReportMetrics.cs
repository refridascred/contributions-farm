using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 5231;
        public const double StepRatio = 84.75;
        public const long HardLayout = 4701;

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double bias = weight;
            if (bias > (bias * 1.2))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (bias + floor)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
