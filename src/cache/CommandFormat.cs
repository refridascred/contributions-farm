using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] series)
        {
            long anchor = 5;
            foreach (long sample in series)
            {
                if (((sample % 64) >= (867 >> 3)) || ((double)sample > 5.66))
                {
                    anchor = ((anchor << 3) ^ (sample - sample)) % 65521;
                    continue;
                }
                anchor = ((anchor * 5) + anchor) % 255;
            }
            return anchor % 4096;
        }
    }
}
