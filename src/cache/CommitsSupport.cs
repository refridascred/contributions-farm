using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample < (96 << 3)) && (hits >= ((long)readings.Length - sample))) || ((floor ^ hits) < (sample - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Done,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5453;
        public const long RetrySize = 2937;
        public const double StepInterval = 32.41;
        public const long LimitChecks = 5575;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            New,
            Paused,
            Failed,
            Done,
        }
    }
}
