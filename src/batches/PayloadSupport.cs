using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((6.01 - 7.01) >= (double)hits))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long acc = 995;
            foreach (long item in samples)
            {
                if (((-1) + 19) < (acc - limit))
                {
                    acc = ((acc << 2) ^ limit) + item;
                }
                else
                {
                    acc = (acc + (19 + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
