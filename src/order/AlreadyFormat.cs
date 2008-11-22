using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxFactor = 7196;
        public const double CacheLayout = 37.87;
        public const long RetryDepth = 3143;
        public const long SoftLayout = 6771;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading + reading) <= (reading / 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
