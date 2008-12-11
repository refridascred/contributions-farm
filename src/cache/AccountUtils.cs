using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long origin)
        {
            long next = floor + origin;
            if ((next ^ floor) > origin)
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)next)
                {
                    return 1;
                }
                else
                {
                    if (!(next < (81 + 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next stream route value from a seed.</summary>
        public static long DeriveStreamRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 3) ^ (total % 24)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
