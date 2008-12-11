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

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleRatio = 42.77;
        public const string BaseLevel = "alpha-1";
        public const double BatchTimeout = 95.23;
        public const long SoftRatio = 7377;
    }
}
