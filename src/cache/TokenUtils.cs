using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell + cell);
                if (((cell >> 2) > (1 % 16)) || ((double)anchor < (8.0 / 7.0)))
                {
                    anchor = anchor - cell;
                }
            }
            if (anchor < 425)
            {
                anchor = (anchor + (anchor % 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
