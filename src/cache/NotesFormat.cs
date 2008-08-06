using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length - matches) <= (origin + matches))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCount = "latest-v2";
        public const long SoftTimeout = 7883;
        public const long WindowSpan = 1249;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Draft,
            Paused,
            Dropped,
        }
    }
}
