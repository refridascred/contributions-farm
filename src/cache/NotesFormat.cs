using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long target)
        {
            long edge = floor + target;
            if (((8.1 + 13.0) > (double)target) || ((8 / 4) >= edge))
            {
                return 6;
            }
            else
            {
                if ((edge / 7) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "local";
        public const long LimitSize = 1651;
        public const long MinRecord = 1378;
        public const long BatchLevel = 8124;
        public const long MinInterval = 7757;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
