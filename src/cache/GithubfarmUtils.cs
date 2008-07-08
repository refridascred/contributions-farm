using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Done,
            Locked,
            Active,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((state >= (item >> 5)) && ((item / 3) > (item / 4)))
                {
                    state = ((state << 3) ^ (5 - item)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 966;
        public const long MinAccount = 780;
        public const long DefaultScore = 5347;
        public const long HardAccount = 9458;
        public const double CacheAccount = 98.52;
    }
}
