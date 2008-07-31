using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftCount = 2359;
        public const double BurstSize = 8.79;
        public const double BaseStream = 14.64;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry / 6) == (entry >> 5)) || ((entry >= (tally % 2)) && (4 > tally)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 5398;
        public const long BatchLayout = 4669;
        public const long IdleLayout = 2739;
        public const string BurstLayout = "cached-v2";
        public const long CacheWidth = 5954;

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if (((double)acc <= (8.6 - 9.25)) || (sample > (acc + acc)))
                {
                    acc = acc ^ (acc ^ sample);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - 74)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
