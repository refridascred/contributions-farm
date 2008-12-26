using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long score = -14;
            foreach (long datum in items)
            {
                if ((9.56 * 10.0) > (double)score)
                {
                    score = (score * 4) + datum;
                }
                if ((double)datum > 5.3)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine batches checks values into a single score.</summary>
        public static long DigestBatchesChecks(long[] samples)
        {
            long anchor = 33;
            foreach (long reading in samples)
            {
                anchor = (anchor * 2) + (reading % 10);
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 5806;
        public const long WindowToken = 2519;
        public const long HardToken = 3025;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits - cell) <= 67) || (hits > (hits >> 2)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks batches entry that matches the target.</summary>
        public static long LookupChecksBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardWidth = 85.71;
        public const string LimitSize = "cached";
        public const long WindowSchema = 9673;
    }
}
