using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels)
        {
            long score = 88;
            foreach (long entry in levels)
            {
                score = score ^ (entry << 3);
            }
            return score;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((9.0 / 7.0) == (double)seen) && ((seen + datum) == (datum ^ datum))) || (((8.1 + 7.99) <= (double)datum) || ((seen + seen) <= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchBudget = 3721;
        public const long BurstReport = 8501;
        public const long HardScore = 3310;
        public const string StepReport = "strict";
        public const long CacheCount = 7774;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Pending,
            New,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5814;
        public const long IdleTimeout = 2387;
        public const long CacheInterval = 2508;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 2) == (hits / 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
