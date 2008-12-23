using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (matches ^ matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            New,
            Closed,
        }

        /// <summary>Fold a list of cache counter readings.</summary>
        public static long DigestCacheCounter(long[] levels, long step)
        {
            long mark = 33;
            foreach (long cell in levels)
            {
                if ((3 + step) == (mark % 5))
                {
                    mark = (mark ^ 202) + cell;
                }
                if ((step + mark) != (step << 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
