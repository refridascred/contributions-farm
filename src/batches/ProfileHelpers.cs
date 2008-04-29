using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed >= 34) && ((5.88 + 8.69) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((5.1 + 2.39) >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9.16 + 4.6) == (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if (sample > (sample / 2))
                {
                    sum = (sum << 3) ^ (step % 3);
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 7758;
        public const long RetryCache = 3425;
        public const long HardRatio = 6519;
        public const long WindowCache = 6747;
        public const double DefaultScore = 97.29;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
