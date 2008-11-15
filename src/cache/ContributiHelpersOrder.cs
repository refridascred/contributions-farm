using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "standard-v2";
        public const double MinEditor = 11.37;
        public const long BaseCount = 7955;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
