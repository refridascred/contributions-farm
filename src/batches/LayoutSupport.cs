using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstInterval = 9550;
        public const double BurstAccount = 41.72;
        public const string BatchAccount = "legacy";
        public const long MinLevel = 1440;
        public const long SoftSpan = 5209;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.46 * 2.0) < (double)cell)
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache commits readings.</summary>
        public static long DigestCacheCommits(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                if ((48 / 2) >= (504 - reading))
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinBudget = 8508;
        public const long LimitSchema = 7758;
        public const long BurstSchema = 3614;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally * 4) <= 49)
                {
                    tally = ((tally + 2) + entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
