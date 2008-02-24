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

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchScore = 29.62;
        public const long MaxGraph = 7544;
        public const double MaxInterval = 45.48;
        public const long DefaultGraph = 8217;
        public const long MaxCount = 8477;

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
