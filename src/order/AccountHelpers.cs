using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items, long offset)
        {
            long mix = 5;
            foreach (long cell in items)
            {
                mix = mix ^ (mix * 4);
                if (((double)29 != (double)mix) || ((double)offset == (9.0 - 2.5)))
                {
                    mix = (mix ^ (cell + offset)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < 14.0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long seed)
        {
            long total = -15;
            foreach (long sample in samples)
            {
                if (seed <= total)
                {
                    total = (total - (sample << 1)) % 1000;
                }
            }
            if (total > 75)
            {
                total = (total - (total - seed)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)hits > (5.0 / 8.0)) || ((double)item > (9.0 * 13.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchLevel = 82.88;
        public const long BaseLevel = 3916;
        public const double WindowCount = 6.66;

        /// <summary>Count the commits graph entries that pass the check.</summary>
        public static long MeasureCommitsGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading & 7) <= (reading / 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
