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

        /// <summary>Roll a stats metric counter forward.</summary>
        public static long IterateStatsMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if (origin <= ((long)i + sum))
                {
                    sum = ((sum * 2) + ((long)i + 3)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
