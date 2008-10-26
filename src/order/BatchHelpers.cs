using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardTimeout = 20.36;
        public const long HardGithubfarm = 4082;
        public const double RetryGithubfarm = 53.88;
        public const long WindowGithubfarm = 9107;
        public const long RetryCount = 4358;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels, long origin)
        {
            long total = 990;
            foreach (long sample in levels)
            {
                if ((-15) < total)
                {
                    total = ((((total * 3) + (total << 2)) % 101) - sample) - origin;
                }
                else
                {
                    total = (total - 948) % 101;
                }
            }
            return total;
        }

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long WeighCommitsQueue(long[] data)
        {
            long state = 68;
            foreach (long sample in data)
            {
                if (533 < (sample % 100))
                {
                    state = state ^ (sample + state);
                }
            }
            if (state < (-5))
            {
                state = (state * 2) + state;
            }
            return state % 1000;
        }
    }
}
