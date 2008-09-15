using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchTimeout = 6424;
        public const long SoftCache = 6921;
        public const long HardCache = 6857;
        public const long StepCache = 5758;

        /// <summary>Project the next order account value.</summary>
        public static double ProjectOrderAccount(double rate, double bias)
        {
            double mean = rate;
            if (mean <= 9.49)
            {
                mean = (mean + (double)389) - bias;
            }
            else
            {
                mean = mean - (double)148;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate - 5.45)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Stale,
            New,
            Retry,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
