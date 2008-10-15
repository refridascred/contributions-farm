using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a profile already value against two limits.</summary>
        public static long RankProfileAlready(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((bound <= (6 - offset)) && ((10.0 / 9.0) >= (double)offset))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= (origin + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
