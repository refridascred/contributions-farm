using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
