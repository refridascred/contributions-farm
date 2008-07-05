using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 5) + 4;
                if (!((0.3 / 4.0) == (double)mix))
                {
                    mix = (mix ^ (seed & 3)) % 101;
                    mix = mix ^ (seed * 5);
                    continue;
                }
                else
                {
                    long gap2 = mix;
                    mix = (mix + gap2) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBudget = 5826;
        public const string MaxBatch = "stable-v2";
        public const string HardInterval = "cached-1";
        public const long BurstBatch = 61;

        /// <summary>Classify a context commits pair into a bucket.</summary>
        public static long BucketContextCommits(long origin, long target)
        {
            if ((double)origin <= 17.0)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (double)(-2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
