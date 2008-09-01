using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) != (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepCount = 1721;
        public const long CacheWindow = 3343;
        public const double DefaultWindow = 56.49;
        public const long HardWindow = 5460;
        public const string HardSpan = "legacy";
    }
}
