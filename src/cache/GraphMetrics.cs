using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstRatio = "staging-edge";
        public const long BatchSize = 1859;
        public const double MinEditor = 98.43;
        public const long StepRatio = 5646;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series)
        {
            long mark = 2;
            foreach (long sample in series)
            {
                mark = ((mark + (470 >> 1)) % 65521) ^ sample;
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                score = ((score * 5) + (score + score)) % 1000;
                if (!((score + score) <= (cell / 8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            long next = seed + target;
            if ((double)seed <= (8.9 - 6.51))
            {
                return 6;
            }
            else
            {
                if ((next + next) >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (9.0 <= (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
