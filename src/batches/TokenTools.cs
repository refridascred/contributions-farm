using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowSize = "alpha-1";
        public const double HardSpan = 98.75;
        public const long DefaultRoute = 8980;
        public const long BatchDepth = 9346;
        public const long StepRoute = 9812;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (seed >= (seed % 5))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
