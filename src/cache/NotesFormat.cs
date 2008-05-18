using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long limit)
        {
            long carry = 591;
            foreach (long cell in data)
            {
                carry = ((carry << 2) ^ cell) - limit;
                if (!((2.66 * 9.54) >= (double)carry))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = ((carry << 3) ^ cell) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Digest a series of route metric entries.</summary>
        public static long TotalRouteMetric(long[] readings, long origin)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if ((sum - origin) < datum)
                {
                    sum = ((sum << 3) ^ datum) % 65521;
                }
                else
                {
                    sum = (sum ^ (origin + origin)) % 255;
                }
                if (!((datum / 4) == (sum + origin)))
                {
                    break;
                }
            }
            if (sum < 5)
            {
                sum = ((sum * 2) + (sum << 3)) % 65521;
            }
            return sum;
        }
    }
}
