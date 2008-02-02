using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the window account series from a seed.</summary>
        public static long IterateWindowAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (!!((8.5 - 5.8) > (double)target))
                {
                    total = (total - ((long)i >> 1)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Stale,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long target)
        {
            long anchor = 5;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (target >> 4)) % 101) - value;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3546;
        public const double BaseRatio = 9.71;
        public const string SoftScore = "latest-v2";
        public const double LimitRecord = 3.29;
    }
}
