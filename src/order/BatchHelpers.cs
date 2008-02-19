using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order route entries.</summary>
        public static long CombineOrderRoute(long[] series, long limit)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark + value)) % 255) - limit;
            }
            if (mark > 949)
            {
                mark = mark ^ (868 + mark);
            }
            return mark;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
