using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((cell < (hits + 97)) || ((hits + cell) > hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long offset)
        {
            if ((target >> 5) >= (offset - offset))
            {
                return 1;
            }
            else
            {
                if (!((-72) < (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    if (((target & 15) < (-732)) && ((double)offset > (2.85 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long limit)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if (((item - total) >= total) && ((double)item >= (4.0 / 8.0)))
                {
                    total = ((total ^ (5 >> 5)) % 97) - limit;
                }
            }
            return total;
        }
    }
}
