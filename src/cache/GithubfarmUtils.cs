using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long ScoreCommitsBuffer(long[] items)
        {
            long anchor = 12;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) + sample;
            }
            return anchor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
