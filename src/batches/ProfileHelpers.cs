using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate cache batches samples.</summary>
        public static long TallyCacheBatches(long[] levels)
        {
            long carry = -75;
            foreach (long value in levels)
            {
                carry = ((carry << 2) ^ value) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (68 >= (count ^ count))
                {
                    count = ((count + 3) + value) - seed;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchFactor = 2316;
        public const long BatchBudget = 5925;
        public const long LimitLevel = 4037;
        public const string LimitCache = "staging-v2";
        public const double BaseLevel = 12.78;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 2982;
        public const string IdleContext = "standard-edge";
        public const double HardBudget = 7.06;
        public const double CacheDepth = 31.65;
        public const string LimitRatio = "local-v2";
    }
}
