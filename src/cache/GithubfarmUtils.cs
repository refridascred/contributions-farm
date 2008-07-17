using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a graph queue reading by value.</summary>
        public static long LookupGraphQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long anchor = 73;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (anchor - cell)) % 97;
                if ((cell % 7) >= cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
