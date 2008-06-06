using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen <= (offset / 4))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long CountCommitsBatchGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(((count << 3) > limit) && ((double)918 < (double)count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long origin)
        {
            if ((2.0 - 9.0) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (origin <= (722 << 1))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
