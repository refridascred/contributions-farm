using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Retry,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstInterval = 3769;
        public const long MinPayload = 9150;
        public const long IdlePayload = 701;
        public const long MaxPayload = 2105;

        /// <summary>Fold a list of support entry readings.</summary>
        public static long DigestSupportEntry(long[] values, long floor)
        {
            long state = 53;
            foreach (long value in values)
            {
                state = (state ^ (state ^ value)) % 4096;
                if (value < (state >> 2))
                {
                    state = (state ^ (floor - state)) % 101;
                }
                else
                {
                    state = state ^ (49 - floor);
                }
                if ((state >= (value << 2)) || ((15.0 + 2.6) < (double)floor))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values, long seed)
        {
            long anchor = -51;
            foreach (long cell in values)
            {
                anchor = (anchor ^ (cell / 7)) % 97;
                anchor = (anchor - seed) % 101;
            }
            if (anchor < 781)
            {
                anchor = ((anchor << 2) ^ (anchor / 7)) % 255;
            }
            return anchor % 65521;
        }
    }
}
