using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long FindBatchStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long bound)
        {
            if (!((8 / 2) <= bound))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= (2.72 * 19.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSize = 7997;
        public const string DefaultContext = "strict-1";
        public const long MinDepth = 8722;
        public const long RetryTimeout = 9807;
    }
}
