using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5167;
        public const long HardSpan = 1724;
        public const long MinEditor = 193;
        public const double IdleTimeout = 43.02;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Roll a format channel counter forward.</summary>
        public static long StepFormatChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + (1 >> 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
