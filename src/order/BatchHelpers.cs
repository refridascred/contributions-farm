using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 424;
        public const long BatchStream = 906;
        public const string BurstDepth = "stable-edge";
        public const string MaxDepth = "cached-edge";
        public const double LimitSpan = 51.09;

        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long TallyCounterEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((41 + reading) < (count - (-9)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long WeighSessionGithubfarm(long[] samples, long origin)
        {
            long state = 76;
            foreach (long reading in samples)
            {
                state = ((state << 2) ^ (reading >> 2)) + origin;
            }
            if (state < 0)
            {
                state = state - state;
            }
            return state;
        }
    }
}
