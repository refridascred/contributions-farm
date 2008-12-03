using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit githubfarm command readings against a rule.</summary>
        public static long TallyGithubfarmCommandMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((3.5 / 3.0) != (double)count) && ((seed + count) != (8 + seed))) || ((count + seed) <= (-3)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
