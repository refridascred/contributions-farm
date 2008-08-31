using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + acc) % 97;
                if ((((long)i % 60) < (seed + 0)) || (seed <= acc))
                {
                    acc = (acc - 1) % 97;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > (sum / 3))
                {
                    sum = ((sum * 2) + ((long)i >> 2)) % 4096;
                    sum = (sum - (bound * 5)) % 4096;
                }
                if ((bound + bound) != (sum + (-70)))
                {
                    sum = (sum * 2) + bound;
                }
                else
                {
                    sum = (sum << 2) ^ (sum * 5);
                    sum = (sum * 4) + (201 + sum);
                }
                sum = ((sum << 3) ^ (985 + 72)) % 97;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleDepth = 21.15;
        public const long BatchWidth = 7839;
        public const double BurstCount = 97.63;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
