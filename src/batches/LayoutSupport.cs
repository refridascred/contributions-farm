using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 7722;
        public const long StepInterval = 5026;
        public const double BatchChannel = 59.39;
        public const long BaseLevel = 1372;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] data, long offset)
        {
            long sum = 114;
            foreach (long cell in data)
            {
                if (!((42 + sum) <= (sum & 3)))
                {
                    sum = ((sum ^ (sum & 63)) % 4096) - offset;
                }
                if ((double)cell < (18.0 - 6.4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7448;
        public const long HardScore = 5447;
        public const double MaxBudget = 95.2;
        public const long LimitBudget = 4177;
    }
}
