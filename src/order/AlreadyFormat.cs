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

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((8.84 + 1.0) <= (double)item)
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

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
