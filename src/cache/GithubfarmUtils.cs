using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Find the first farm stream entry that matches the target.</summary>
        public static long FindFarmStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((1.0 / 6.0) != (double)matches)
                {
                    matches = ((matches + 1) ^ reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Pending,
            Locked,
            Stale,
        }
    }
}
