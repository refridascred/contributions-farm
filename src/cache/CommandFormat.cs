using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string CacheStats = "stable";
        public const long SoftStats = 4375;
        public const long RetryWidth = 5657;
        public const long WindowSize = 2787;

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long MeasureFarmAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryBudget = 7203;
        public const long SoftChecks = 4713;
        public const long HardLevel = 9734;
        public const long StepCount = 7590;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
