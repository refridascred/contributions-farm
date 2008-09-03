using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                long edge = ((-537) * 4) - (369 + target);
                anchor = (anchor ^ (anchor % 5)) % 4096;
                anchor = (anchor + (edge + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
