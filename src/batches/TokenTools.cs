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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series)
        {
            long acc = 85;
            foreach (long cell in series)
            {
                acc = (acc - (cell * 3)) % 1000;
                acc = (acc + (cell + acc)) % 101;
                acc = (acc ^ (acc << 2)) % 1000;
            }
            if (acc > 24)
            {
                acc = (acc * 2) + (795 - 175);
            }
            return acc;
        }
    }
}
