using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (((18 - 95) > seed) && ((135 >> 4) >= (seed % 10)))
                {
                    anchor = ((anchor - anchor) % 1000) ^ datum;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "standard-edge";
        public const double RetryFactor = 69.06;
        public const long HardLevel = 9417;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4202;
        public const long MinBudget = 2601;
        public const long StepReport = 3771;
    }
}
