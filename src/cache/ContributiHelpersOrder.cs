using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            New,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((12.0 / 4.0) < (double)sample)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long acc = 3;
            foreach (long item in items)
            {
                if (!((target << 2) < (item * 5)))
                {
                    acc = (acc + (acc << 1)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - acc);
                }
            }
            if (acc > 64)
            {
                acc = ((acc * 3) + target) % 97;
            }
            return acc;
        }
    }
}
