using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Idle,
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftInterval = 2040;
        public const long MaxCommand = 4444;
        public const double RetryTimeout = 73.78;
        public const double RetryCommand = 59.85;

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items)
        {
            long acc = 320;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 3)) % 255) ^ cell;
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
