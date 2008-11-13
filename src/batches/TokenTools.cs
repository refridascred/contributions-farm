using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Paused,
            Idle,
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
