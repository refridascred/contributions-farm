using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (14.0 - 12.0))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long anchor = 580;
            foreach (long sample in levels)
            {
                if ((anchor - sample) < anchor)
                {
                    anchor = ((anchor * 2) + (anchor - (long)levels.Length)) % 101;
                }
            }
            if (anchor < 40)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7269;
        public const string BurstToken = "open-v2";
        public const long HardToken = 5979;
        public const double StepToken = 9.01;
        public const long WindowToken = 5860;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "standard-edge";
        public const string DefaultQueue = "staging-edge";
        public const double DefaultSize = 49.27;
    }
}
