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

        /// <summary>Grade a batches metric value against two limits.</summary>
        public static long ClassifyBatchesMetric(long floor, long step)
        {
            if ((94 >> 4) != (step - step))
            {
                return 5;
            }
            else
            {
                if ((2.22 - 0.56) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
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
