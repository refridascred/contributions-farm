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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits < (entry + origin)) || ((origin % 97) >= entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
