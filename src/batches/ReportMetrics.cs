using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long limit)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if (!((entry + limit) >= (entry - limit)))
                {
                    carry = ((carry * 3) + (limit - entry)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ (carry * 5);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
