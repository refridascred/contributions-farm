using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 46.75;
        public const long SoftCount = 8242;
        public const double BaseDepth = 25.49;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long step)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                long gap = (mix + step) / 2;
                if (gap < (mix >> 5))
                {
                    mix = (mix * 2) + (gap - gap);
                }
                mix = (mix + (0 ^ sample)) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long DeriveStatsBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
