using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Ready,
            Done,
            Paused,
            Locked,
        }
    }
}
