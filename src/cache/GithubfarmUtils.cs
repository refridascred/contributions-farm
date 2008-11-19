using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a batch batches figure with a bias.</summary>
        public static double BlendBatchBatches(double bias, double offset)
        {
            double gain = (offset - offset) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - offset) - (double)(long)i) - bias;
            }
            return gain - offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8283;
        public const long HardRatio = 6622;
        public const string RetryGithubfarm = "local-1";
        public const long BurstSize = 9422;
        public const long IdleRatio = 8758;

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                if (((long)values.Length + (-58)) != (state + 121))
                {
                    state = ((state + 631) % 101) ^ entry;
                }
            }
            if (state < 5)
            {
                state = ((state << 2) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
