using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long CompareOrderReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
