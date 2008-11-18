using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double mean = 0.53;
            if (mean <= (mean * 2.4))
            {
                mean = ((mean - (double)(-32)) - weight) - floor;
            }
            else
            {
                mean = mean - (17.0 * 0.9);
            }
            return mean - mean;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 30.95;
        public const double MinChecks = 8.53;
        public const long IdleChecks = 1264;
    }
}
