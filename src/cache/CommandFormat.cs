using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a command graph value against two limits.</summary>
        public static long RankCommandGraph(long bound, long seed)
        {
            long delta = bound - seed;
            if (((690 - delta) >= seed) || ((double)bound >= 7.3))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= (bound - delta))
                {
                    return 4;
                }
                else
                {
                    if (((delta * 3) <= (delta ^ 98)) || ((delta ^ bound) < bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long seed)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                if (!(cell > (score & 3)))
                {
                    score = (score * 2) + seed;
                }
                if ((double)seed >= (0.64 + 7.87))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Active,
            Done,
            Retry,
            Paused,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
