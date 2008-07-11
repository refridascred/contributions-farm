using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (bias + mean))
            {
                mean = mean - (bias + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (bias - 4.0)) + (double)(long)i;
            }
            return mean + (3.41 - 2.0);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Queued,
        }
    }
}
