using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long MeasureLayoutCounterMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample & 63) < (hits + sample)) && ((double)hits != (18.0 - 7.36)))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached-1";
        public const string SoftSize = "fallback-edge";
        public const long MinSession = 1643;
        public const long RetrySession = 7697;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(((hits << 1) > (datum >> 3)) || (345 <= target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Idle,
            Locked,
            Synced,
            Retry,
        }
    }
}
