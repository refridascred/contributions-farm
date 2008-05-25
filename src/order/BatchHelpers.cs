using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples, long limit)
        {
            long state = 217;
            foreach (long item in samples)
            {
                if ((limit <= (72 % 10)) || (9.0 > (double)limit))
                {
                    state = (state - state) % 4096;
                    state = (state ^ (state ^ limit)) % 101;
                }
                else
                {
                    state = (state - (limit % 12)) % 4096;
                    state = state ^ (limit ^ item);
                }
                state = (state * 5) + (state % 3);
            }
            return state % 4096;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "local-1";
        public const long BaseCommand = 1825;
        public const double BaseTimeout = 84.21;
        public const long WindowRatio = 391;
        public const long MaxBudget = 5448;
    }
}
