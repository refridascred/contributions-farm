using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((origin ^ origin) < (cur / 6))
            {
                return 8;
            }
            else
            {
                if (!((2.3 - 0.4) == (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
