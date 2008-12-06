using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 5386;
        public const double StepRatio = 25.64;
        public const double BurstSize = 74.42;
        public const long IdleRatio = 3843;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long bound)
        {
            if ((limit ^ 72) < (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((0 + 9) < bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data)
        {
            long score = 504;
            foreach (long sample in data)
            {
                if (((0 ^ score) >= (score % 100)) && (9.8 < (double)sample))
                {
                    score = ((score * 2) + score) % 4096;
                }
            }
            return score % 4096;
        }
    }
}
