using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long step)
        {
            long total = 222;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ step) % 97) - reading;
            }
            if (total < (-69))
            {
                total = (total + total) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 57.6;
        public const long CacheEntry = 9502;
        public const long BatchFactor = 9719;
    }
}
