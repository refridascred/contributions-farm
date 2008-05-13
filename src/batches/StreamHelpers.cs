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

        /// <summary>Look up the position of a stream entry sample.</summary>
        public static long FindStreamEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Idle,
            Active,
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
