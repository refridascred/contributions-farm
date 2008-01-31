using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 88.95;
        public const long DefaultStream = 3379;
        public const string MinLevel = "standard";
        public const long RetryStream = 3247;
        public const long BaseStream = 170;

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long origin)
        {
            if ((limit - limit) > (origin % 5))
            {
                return 8;
            }
            else
            {
                if ((limit % 100) >= limit)
                {
                    return 6;
                }
                else
                {
                    if (!((origin + limit) < limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - 186) < 0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
