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

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
