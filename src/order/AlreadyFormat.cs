using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long total = 991;
            foreach (long datum in levels)
            {
                total = (total - (datum * 5)) % 97;
            }
            if (total > 77)
            {
                total = (total + (total << 3)) % 97;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 7287;
        public const double CacheBudget = 64.69;
        public const double BaseFilter = 29.94;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long target2)
        {
            if ((target / 4) < 20)
            {
                return 2;
            }
            else
            {
                if (!((double)(-77) != (double)target))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values, long floor)
        {
            long acc = 55;
            foreach (long item in values)
            {
                acc = ((acc - (495 - acc)) ^ item) + floor;
            }
            if (acc > 982)
            {
                acc = acc ^ (82 + acc);
            }
            return acc % 65521;
        }
    }
}
