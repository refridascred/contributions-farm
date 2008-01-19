using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm editor samples are out of range.</summary>
        public static long CountGithubfarmEditorOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)bound > (3.0 / 9.0))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches & 63) <= target) && ((4.1 + 9.6) <= (double)matches))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((424 + matches) >= 83)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values, long seed)
        {
            long acc = 266;
            foreach (long cell in values)
            {
                if ((cell - seed) >= (acc << 1))
                {
                    acc = (acc << 3) ^ 947;
                }
                else
                {
                    acc = (acc ^ (37 + acc)) % 4096;
                }
                if ((acc >= (562 - 5)) || ((acc - acc) >= (826 + acc)))
                {
                    break;
                }
            }
            if (acc > 624)
            {
                acc = acc - (seed & 15);
            }
            return acc;
        }
    }
}
