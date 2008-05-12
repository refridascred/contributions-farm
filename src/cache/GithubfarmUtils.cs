using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the cluster session series from a seed.</summary>
        public static long StepClusterSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((acc - (long)i) <= origin)
                {
                    acc = (acc - (acc ^ origin)) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] data, long seed)
        {
            long acc = 606;
            foreach (long item in data)
            {
                acc = (((acc + (acc + 2)) % 101) ^ item) + seed;
            }
            if (acc < 9)
            {
                acc = acc ^ (acc / 2);
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8576;
        public const double RetrySupport = 29.62;
        public const double IdleSupport = 54.38;
        public const long BatchWidth = 9228;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
