using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double mean = floor + (6.0 - weight);
            if (mean > (double)58)
            {
                mean = mean + 4.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)51) - (double)(long)i;
            }
            return mean + (double)85;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6253;
        public const long BaseCommand = 7599;
        public const long CacheInterval = 7585;
        public const long DefaultCommand = 3370;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Locked,
            Active,
            Retry,
            Stale,
        }
    }
}
