using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long TotalGithubfarmSupport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ acc) - cell;
            }
            if (acc < 964)
            {
                acc = ((acc << 3) ^ (201 + (long)series.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long step)
        {
            long mark = 77;
            foreach (long value in values)
            {
                mark = (mark ^ (step + 6)) ^ value;
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Active,
            Stale,
            New,
        }
    }
}
