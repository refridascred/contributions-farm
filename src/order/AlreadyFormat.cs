using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metric batches entries that pass the check.</summary>
        public static long MeasureMetricBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((cell / 8) == (count + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 1.48;
        public const long MinFactor = 3491;
        public const double RetryStats = 46.49;
        public const double SoftStats = 89.7;
        public const long MaxWidth = 9769;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Draft,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Idle,
            Done,
            Draft,
            Closed,
        }
    }
}
