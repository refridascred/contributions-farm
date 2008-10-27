using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 4563;
        public const string MinScore = "staging-v2";
        public const long StepChecks = 6803;

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
