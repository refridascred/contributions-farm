using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batch counter samples are out of range.</summary>
        public static long TallyBatchCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((12.0 - 5.0) <= (double)hits)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long offset)
        {
            if ((6.02 / 5.0) > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset & 3) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
