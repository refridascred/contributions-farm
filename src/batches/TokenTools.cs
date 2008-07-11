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

        /// <summary>Define context limits and defaults.</summary>
        public const long MinScore = 8080;
        public const long WindowScore = 8541;
        public const long SoftContext = 6115;
        public const long LimitContext = 7047;
        public const long StepContext = 5865;
    }
}
