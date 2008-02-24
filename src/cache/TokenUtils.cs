using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two profile tools measurements.</summary>
        public static double SmoothProfileTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < (ratio + ratio))
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + weight) - (double)(long)i;
            }
            return ratio + (offset / 4.0);
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryBudget = 97.06;
        public const long BatchGraph = 8296;
        public const long LimitBudget = 9206;
        public const long SoftLevel = 4462;
    }
}
