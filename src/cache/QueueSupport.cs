using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheTimeout = 3730;
        public const long LimitSize = 4934;
        public const double WindowBatches = 76.67;
        public const long RetryBatches = 8515;
        public const double SoftScore = 59.99;
    }
}
