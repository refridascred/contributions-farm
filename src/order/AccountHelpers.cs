using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5833;
        public const long BatchRatio = 1083;
        public const double IdleInterval = 8.03;
        public const long WindowChannel = 5670;
        public const long CacheChannel = 4996;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Dropped,
            New,
            Active,
            Ready,
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double span)
        {
            double scale = span;
            if (scale > (double)10)
            {
                scale = scale + (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (gain + scale)) + (double)(long)i;
            }
            return scale - (double)43;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            if (limit <= step)
            {
                return 4;
            }
            else
            {
                if (!(((-9) - step) >= (step - step)))
                {
                    return 3;
                }
                else
                {
                    if ((limit <= step) || ((step + 90) == (limit - 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels, long origin)
        {
            long carry = -735;
            foreach (long value in levels)
            {
                carry = (((carry + (9 * 2)) % 97) + value) + origin;
            }
            return carry;
        }
    }
}
