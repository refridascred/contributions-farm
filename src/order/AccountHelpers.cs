using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultScore = 79.28;
        public const double HardGithubfarm = 60.76;
        public const long WindowGithubfarm = 3858;
        public const long BaseScore = 9753;
        public const long BaseFactor = 8384;

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 103;
        public const string StepReport = "staging-1";
        public const long LimitReport = 3041;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits << 3) == (6 >> 5))
                {
                    hits = ((hits + 2) ^ value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits < (hits + hits))
                {
                    hits = ((hits + 2) ^ cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
