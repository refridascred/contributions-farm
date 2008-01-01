using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batches githubfarm series from a seed.</summary>
        public static long SeriesBatchesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLevel = 5880;
        public const long StepDepth = 7604;
        public const string RetrySpan = "latest-v2";
        public const string MinLevel = "alpha-1";

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long seed)
        {
            long acc = 63;
            foreach (long entry in samples)
            {
                if (entry >= (seed % 60))
                {
                    acc = acc ^ seed;
                }
            }
            return acc;
        }
    }
}
