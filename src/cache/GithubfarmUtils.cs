using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BurstSpan = 50.44;
        public const string CacheSize = "stable-v2";
        public const double RetrySize = 72.1;
        public const long IdleReport = 8884;

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels, long bound)
        {
            long total = 307;
            foreach (long reading in levels)
            {
                total = ((total << 2) ^ (reading << 1)) + bound;
            }
            return total % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                mark = (((mark << 3) ^ (5 ^ mark)) - cell) - offset;
                if ((-9) >= mark)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Paused,
            New,
            Queued,
            Pending,
        }
    }
}
