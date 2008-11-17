using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 678;
        public const double MaxBudget = 29.0;
        public const long BurstSpan = 7453;

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double scale = (double)(0 - 63);
            if (scale < span)
            {
                scale = scale + (1.0 - 6.05);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (2.7 - ratio);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            New,
            Paused,
            Pending,
            Queued,
        }
    }
}
