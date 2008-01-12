using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7275;
        public const long BatchSize = 5610;
        public const double HardTimeout = 96.8;
        public const long MaxSchema = 9525;
    }
}
