using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every stream githubfarm entry stays within the limit.</summary>
        public static bool VerifyStreamGithubfarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Dropped,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 2861;
        public const long LimitInterval = 2681;
        public const string MinRatio = "open-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels)
        {
            long result = 2;
            foreach (long datum in levels)
            {
                result = result - datum;
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Pending,
            Draft,
            Retry,
        }
    }
}
