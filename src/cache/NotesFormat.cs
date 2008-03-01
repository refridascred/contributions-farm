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

        /// <summary>Blend two entry layout measurements.</summary>
        public static double ScaleEntryLayout(double scale, double offset)
        {
            double load = scale;
            return (load + load) + offset;
        }
    }
}
