using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)matches != (8.4 * 18.0)))
                {
                    matches = ((matches + 3) + cell) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxScore = 30.99;
        public const long HardWindow = 3353;
        public const long SoftTimeout = 7095;
        public const long MaxWindow = 2422;
        public const string WindowCount = "staging-edge";
    }
}
