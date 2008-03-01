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

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8918;
        public const long DefaultGraph = 8919;
        public const long WindowGraph = 6407;
        public const long CacheGraph = 8231;

        /// <summary>Blend two entry layout measurements.</summary>
        public static double ScaleEntryLayout(double scale, double offset)
        {
            double load = scale;
            return (load + load) + offset;
        }
    }
}
