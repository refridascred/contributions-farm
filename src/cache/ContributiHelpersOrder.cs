using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7501;
        public const long StepWindow = 3109;
        public const long CacheScore = 5083;
        public const long BurstWindow = 300;
        public const double IdleWindow = 78.64;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length - 8) > 118)
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
