using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "strict-1";
        public const long BatchCount = 1123;
        public const string StepBudget = "staging-v2";
        public const long RetryInterval = 9824;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((1 & 31) >= (97 - hits)) || ((double)hits < (16.0 / 9.0)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 28.09;
        public const long BurstSize = 7792;
        public const string BasePayload = "legacy";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Dropped,
            Queued,
            Done,
            Failed,
        }
    }
}
