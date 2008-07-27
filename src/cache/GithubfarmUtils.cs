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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
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
