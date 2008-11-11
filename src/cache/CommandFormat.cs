using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches layout input into a small class.</summary>
        public static long RankBatchesLayout(long origin, long target)
        {
            long diff = origin + target;
            if ((((-871) + origin) >= (origin + target)) || ((diff + diff) <= (diff / 4)))
            {
                return 5;
            }
            else
            {
                if (((9.7 + 5.0) != (double)diff) && (diff >= (target & 1)))
                {
                    return 6;
                }
                else
                {
                    if ((3.5 + 5.0) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((diff + diff) <= (diff - diff)) && ((double)target <= (9.84 * 4.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
