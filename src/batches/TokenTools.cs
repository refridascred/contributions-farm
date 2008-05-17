using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseDepth = "strict-1";
        public const long MaxFactor = 2862;
        public const string DefaultFactor = "fallback-1";
        public const long BatchCount = 3537;
        public const double DefaultGraph = 73.84;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            New,
            Active,
            Dropped,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((step + seen) == (seen + datum)) || !((seen % 7) < step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
