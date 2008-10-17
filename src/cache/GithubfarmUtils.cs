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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series, long seed)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if ((double)seed > (5.9 * 5.7))
                {
                    mark = mark - entry;
                }
            }
            if (mark < 0)
            {
                mark = (mark << 2) ^ (mark % 10);
            }
            return mark;
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

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool ValidateBatchesReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
