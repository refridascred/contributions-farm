using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of schema filter readings.</summary>
        public static long ScoreSchemaFilter(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ total) % 4096) + entry;
            }
            if (total > 89)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long limit)
        {
            long span = offset - limit;
            if ((span > limit) && ((7.0 / 5.0) >= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (double)span)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((608 % 7) == (value & 15))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long anchor = 45;
            foreach (long value in levels)
            {
                anchor = (anchor + (value % 97)) % 97;
            }
            return anchor;
        }
    }
}
