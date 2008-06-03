using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 3643;
        public const string RetryBudget = "alpha";
        public const double DefaultTimeout = 6.63;
        public const long CacheBudget = 1221;
        public const string HardFactor = "staging-1";

        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > (sample / 4))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
