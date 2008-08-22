using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long anchor = 38;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (item ^ item)) % 1000;
                if (item >= (long)levels.Length)
                {
                    anchor = (anchor + (anchor + anchor)) % 101;
                }
                if ((anchor >= (anchor * 4)) || ((20.0 - 4.6) >= (double)item))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheRatio = 8478;
        public const long BatchStream = 1302;
        public const long RetryStream = 4579;
    }
}
