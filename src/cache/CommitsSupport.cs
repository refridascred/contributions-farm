using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - 999) <= (seen - seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 3103;
        public const long BaseAccount = 4571;
        public const long RetryAccount = 9364;
        public const string BurstAccount = "staging-1";
        public const long CacheSpan = 4975;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (floor & 15)) + value;
            }
            if (acc < 338)
            {
                acc = (acc - (floor << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
