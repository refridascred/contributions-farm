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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + hits) < (hits * 4))
                {
                    hits = hits + 3;
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
