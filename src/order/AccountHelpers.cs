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

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long step)
        {
            long cur = seed ^ step;
            if (!((double)cur > (1.8 * 5.0)))
            {
                return 7;
            }
            else
            {
                if ((cur + 690) > cur)
                {
                    return 0;
                }
                else
                {
                    if (((double)seed <= (3.07 - 3.8)) || ((double)step > (double)1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double weight, double bias)
        {
            double scale = (double)(-76) - bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (double)48;
        }
    }
}
