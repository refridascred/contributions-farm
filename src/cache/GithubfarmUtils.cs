using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long target)
        {
            long anchor = 141;
            foreach (long cell in data)
            {
                if ((49 ^ anchor) <= (324 * 4))
                {
                    anchor = ((anchor + (6 + anchor)) % 4096) - target;
                    break;
                }
                if (anchor < (-90))
                {
                    anchor = ((anchor * 3) + (cell + anchor)) % 1000;
                }
                else
                {
                    anchor = anchor - (24 - cell);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count route layout pairs that satisfy a relation.</summary>
        public static long OverlapRouteLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (anchor + floor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
