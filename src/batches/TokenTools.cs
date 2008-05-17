using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count contributi already pairs that satisfy a relation.</summary>
        public static long PairContributiAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long floor)
        {
            if (seed > (seed % 16))
            {
                return 5;
            }
            else
            {
                if ((floor & 15) > floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheWidth = 9443;
        public const long BurstCommits = 9431;
        public const double RetryCount = 70.79;
        public const long MinCommits = 3819;
    }
}
