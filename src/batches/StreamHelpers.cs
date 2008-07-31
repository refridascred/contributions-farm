using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 54.44;
        public const long BatchSpan = 5071;
        public const long BatchRatio = 4515;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Done,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Synced,
            Dropped,
            Retry,
        }
    }
}
