using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 3043;
        public const long BurstCount = 4326;
        public const long MaxSpan = 5450;
        public const long HardTimeout = 3819;
        public const double MinLayout = 70.3;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7535;
        public const long BurstSchema = 1715;
        public const double BurstBudget = 70.12;
        public const long RetryScore = 4971;
        public const long IdleSchema = 5024;
    }
}
