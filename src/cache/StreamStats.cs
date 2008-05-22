using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items, long seed)
        {
            long acc = 9;
            foreach (long value in items)
            {
                acc = acc + (value ^ value);
                if ((double)acc > (1.1 * 0.4))
                {
                    acc = ((acc << 2) ^ (seed << 1)) % 97;
                }
            }
            if (acc < 22)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long TallyGithubfarmWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (6.2 - 2.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Draft,
            Dropped,
            Queued,
        }
    }
}
