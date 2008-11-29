using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "open-v2";
        public const long WindowSpan = 3370;
        public const long SoftScore = 42;
        public const long BatchSpan = 7692;
        public const double MinNotes = 9.78;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Done,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5362;
        public const string DefaultBatches = "stable";
        public const long RetryBatches = 359;

        /// <summary>Count the already order entries that pass the check.</summary>
        public static long MeasureAlreadyOrderMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits > (8.0 / 3.0))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a account stats figure with a bias.</summary>
        public static double AdjustAccountStats(double ratio, double offset)
        {
            double load = (double)((-68) >> 1);
            if (load >= load)
            {
                load = (load + (ratio + 3.0)) - offset;
            }
            else
            {
                load = load + (5.7 * 20.0);
            }
            return load + (load + 9.2);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
