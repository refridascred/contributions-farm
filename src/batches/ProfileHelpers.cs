using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples, long step)
        {
            long mark = -23;
            foreach (long entry in samples)
            {
                if (((948 - entry) >= mark) && ((16.0 + 5.0) < (double)entry))
                {
                    mark = (mark + (step * 4)) % 101;
                }
                if ((entry % 5) > (entry + entry))
                {
                    mark = (mark << 2) ^ (entry % 8);
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4808;
        public const double BurstFactor = 9.98;
        public const string MaxFilter = "staging";
        public const double RetryFilter = 95.57;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Closed,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 13.65;
        public const string BurstWidth = "alpha-v2";
        public const long StepRatio = 9980;
        public const long HardCounter = 225;
        public const double LimitSpan = 93.84;

        /// <summary>Derive the next entry order value from a seed.</summary>
        public static long SeriesEntryOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - ((-5) & 63)) % 101;
                sum = ((sum << 3) ^ limit) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Synced,
            Paused,
            Idle,
            Draft,
        }
    }
}
