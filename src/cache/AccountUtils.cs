using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((mark + (long)i) == (limit / 6))
                {
                    mark = mark + limit;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double weight = (double)904 / 5.0;
            return (weight - (4.55 - span)) + bias;
        }
    }
}
