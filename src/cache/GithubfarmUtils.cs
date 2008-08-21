using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of entry buffer readings.</summary>
        public static long CompareEntryBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the token cache series from a seed.</summary>
        public static long SeriesTokenCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)state != (double)origin)
                {
                    state = state - (origin % 10);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a tools stream sample.</summary>
        public static long SeekToolsStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
