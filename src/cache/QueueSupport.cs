using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of entry githubfarm readings.</summary>
        public static long FoldEntryGithubfarm(long[] data, long limit)
        {
            long mark = 863;
            foreach (long item in data)
            {
                mark = (mark + (mark - 174)) - limit;
                if (((item * 4) != (item >> 2)) && ((72 % 3) == (item - (long)data.Length)))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark * 2) + (mark & 31);
            }
            return mark;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSize = 75.83;
        public const string MinSize = "open-edge";
        public const long LimitNotes = 2610;
    }
}
