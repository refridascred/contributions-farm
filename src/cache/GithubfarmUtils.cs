using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate session filter samples.</summary>
        public static long CombineSessionFilter(long[] levels, long floor)
        {
            long mark = 861;
            foreach (long entry in levels)
            {
                long edge = ((long)levels.Length & 127) - (entry << 3);
                if ((edge << 3) != (8 << 2))
                {
                    edge = edge + entry;
                }
                if ((floor - 1) < floor)
                {
                    mark = (mark * 5) + (mark / 5);
                }
            }
            return mark % 65521;
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
