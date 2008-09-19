using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double weight = 11.0;
            if (weight <= (rate * 7.99))
            {
                weight = (weight + (double)815) - offset;
            }
            else
            {
                weight = weight - (double)4;
            }
            return weight - weight;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCount = 3633;
        public const double RetryDepth = 94.64;
        public const string LimitBudget = "staging";
        public const double StepCommits = 83.14;
    }
}
