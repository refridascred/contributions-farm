using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 9798;
        public const long WindowStream = 230;
        public const long HardInterval = 6732;
        public const double WindowFactor = 77.27;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm metric samples are out of range.</summary>
        public static long TallyGithubfarmMetricOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < hits)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
