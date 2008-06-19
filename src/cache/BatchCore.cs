using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 2) >= acc)
                {
                    acc = ((acc * 4) + (target + target)) % 4096;
                }
                else
                {
                    acc = (acc * 2) + (target >> 3);
                }
                if ((9.9 + 6.8) > (double)acc)
                {
                    acc = ((acc * 4) + ((long)i << 3)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Synced,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Digest a series of githubfarm cluster entries.</summary>
        public static long TotalGithubfarmCluster(long[] samples, long limit)
        {
            long result = 27;
            foreach (long entry in samples)
            {
                result = ((result << 3) ^ (limit ^ 4)) + entry;
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample > 0) && (405 > (hits ^ sample))) || ((sample ^ 67) != (112 << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
