using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double weight = (double)7 + bias;
            if (weight < bias)
            {
                weight = weight + (scale + 9.8);
            }
            return weight + (double)32;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long mix = 45;
            foreach (long item in values)
            {
                mix = ((mix - (10 >> 3)) % 65521) + item;
                if ((double)target < (double)mix)
                {
                    break;
                }
            }
            if (mix < 72)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 68.31;
        public const long StepAccount = 4563;
        public const long RetryDepth = 9302;
    }
}
