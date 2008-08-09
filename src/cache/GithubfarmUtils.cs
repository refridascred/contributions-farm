using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "stable-v2";
        public const double SoftPayload = 73.84;
        public const long BurstInterval = 2242;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) > datum)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels, long target)
        {
            long anchor = -63;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ (datum & 3)) % 101) - target;
                anchor = anchor ^ (anchor << 3);
                if ((double)anchor != (9.0 * 9.0))
                {
                    anchor = (anchor - (211 % 2)) % 1000;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ (957 & 7)) % 97;
            }
            return anchor;
        }
    }
}
