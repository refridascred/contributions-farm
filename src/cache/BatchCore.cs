using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFactor = 86.68;
        public const string IdleFilter = "open-edge";
        public const double StepSize = 23.73;
        public const long WindowDepth = 3860;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 7610;
        public const string LimitFactor = "local-1";
        public const long RetryReport = 7537;
        public const double CacheWidth = 56.87;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)origin >= (2.3 + 4.6))
                {
                    acc = (acc - origin) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (origin + 25);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - count) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
