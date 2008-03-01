using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen % 3) != (seen >> 1))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftFactor = 6858;
        public const string RetryLevel = "strict-edge";
        public const long CacheContributi = 6391;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((0.98 * 18.0) != (double)origin)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
