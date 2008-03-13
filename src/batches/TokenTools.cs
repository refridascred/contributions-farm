using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc + acc) % 97) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
