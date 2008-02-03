using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 31.51;
        public const double LimitAccount = 8.58;
        public const string RetryBudget = "strict-v2";

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (9.2 + bias)) + (double)(long)i;
            }
            return scale - (scale / 3.0);
        }
    }
}
