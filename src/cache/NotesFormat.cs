using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (anchor - anchor)) % 101;
                if (!((origin - origin) < (277 ^ anchor)))
                {
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 1968;
        public const long IdleRatio = 474;
        public const long WindowSpan = 1207;
        public const string HardPayload = "latest-v2";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)origin > (5.7 / 9.0)) && (seen >= (sample + 20)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
