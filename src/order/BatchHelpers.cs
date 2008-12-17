using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 8937;
        public const string MinBudget = "primary";
        public const long LimitGraph = 6659;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = gain - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 4.0) + (double)(long)i;
            }
            return gain + (15.0 + gain);
        }
    }
}
