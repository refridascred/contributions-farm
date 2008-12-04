using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Active,
            Stale,
            Draft,
            New,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double rate = (bias / 8.0) - bias;
            if (rate >= (double)24)
            {
                rate = (rate - (rate * 5.0)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)699) + (double)(long)i;
            }
            return rate + 20.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 7765;
        public const long RetryDepth = 739;
        public const long MaxBudget = 6224;
    }
}
