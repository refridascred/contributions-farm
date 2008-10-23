using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long floor)
        {
            if ((floor + floor) <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if (!((9 - bound) == (bound * 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + 746) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Pending,
            Active,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            if (((2.0 - 9.95) >= (double)floor) && ((floor * 2) > (floor + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin + 6) == (floor % 64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
