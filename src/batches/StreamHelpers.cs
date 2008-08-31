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

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 4435;
        public const long DefaultToken = 4115;
        public const long BatchToken = 986;
        public const string HardToken = "staging-edge";

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
