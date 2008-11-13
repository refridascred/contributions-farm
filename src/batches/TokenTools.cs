using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the support order series from a seed.</summary>
        public static long RollSupportOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)seed < (15.0 - 1.12)))
                {
                    anchor = anchor + ((long)i + seed);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings, long bound)
        {
            long total = -6;
            foreach (long value in readings)
            {
                total = ((total - 449) ^ value) - bound;
                if ((18.0 * 7.3) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
