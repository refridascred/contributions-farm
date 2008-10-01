using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long step)
        {
            long state = 869;
            foreach (long sample in items)
            {
                state = ((state ^ 593) % 4096) ^ sample;
            }
            if (state > 6)
            {
                state = state - (46 - step);
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 0.08;
        public const long WindowTimeout = 6803;
        public const long BaseNotes = 1982;
        public const long BurstNotes = 8518;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Stale,
            Idle,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
