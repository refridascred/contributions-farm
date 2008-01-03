using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long floor)
        {
            if ((3.39 * 5.9) > (double)limit)
            {
                return 6;
            }
            else
            {
                if (!((floor & 255) == (limit >> 5)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((4 & 255) <= (cell & 1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
