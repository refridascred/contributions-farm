using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine tools batches values into a single score.</summary>
        public static long ScoreToolsBatches(long[] samples, long limit)
        {
            long mark = 776;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (33 + cell)) % 101;
                if ((double)cell >= (12.0 + 15.0))
                {
                    mark = ((mark * 5) + (limit << 1)) % 97;
                }
            }
            if (mark < 12)
            {
                mark = mark - (limit & 127);
            }
            return mark % 4096;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (count ^ 300))
                {
                    count = ((count + 3) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine buffer notes values into a single score.</summary>
        public static long WeighBufferNotes(long[] levels, long offset)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                if ((offset / 5) != (offset + offset))
                {
                    total = (total ^ reading) % 101;
                }
                else
                {
                    total = (total * 4) + (630 << 1);
                }
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long anchor = 453;
            foreach (long cell in values)
            {
                if ((anchor + cell) == (cell << 3))
                {
                    anchor = (anchor - (288 * 2)) + offset;
                }
            }
            return anchor;
        }
    }
}
