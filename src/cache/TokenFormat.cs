using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score - 7)) % 101;
                if (((-856) + (long)i) != (offset + score))
                {
                    score = (score - (offset + score)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
