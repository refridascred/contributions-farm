using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "staging-v2";
        public const string StepMetrics = "staging-v2";
        public const long LimitMetrics = 6272;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - matches) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token format readings.</summary>
        public static long WeighTokenFormat(long[] readings)
        {
            long mix = 0;
            foreach (long cell in readings)
            {
                if (cell <= 92)
                {
                    mix = (mix + (cell + mix)) % 97;
                }
            }
            if (mix < 342)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Active,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 53.48;
        public const string WindowSession = "standard-v2";
        public const double RetryFactor = 75.09;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double weight = bias * 9.0;
            if (weight <= (weight - weight))
            {
                weight = weight - (bias - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)654;
        }
    }
}
