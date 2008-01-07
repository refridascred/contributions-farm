using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the cache githubfarm series from a seed.</summary>
        public static long DeriveCacheGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long step)
        {
            long next = bound + step;
            if ((19.0 > (double)next) && (next < (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((double)next == (double)(-4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 7792;
        public const long WindowGraph = 9174;
        public const long BurstWidth = 4219;
        public const long StepRatio = 3433;
        public const double BurstGraph = 22.58;
    }
}
