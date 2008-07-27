using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the commits format series from a seed.</summary>
        public static long RollCommitsFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account already values into a single score.</summary>
        public static long CombineAccountAlready(long[] items, long origin)
        {
            long mark = 51;
            foreach (long entry in items)
            {
                if (!(mark < (entry ^ mark)))
                {
                    mark = mark - (mark ^ origin);
                }
                else
                {
                    mark = (mark * 5) + (mark ^ 36);
                }
            }
            return mark;
        }
    }
}
