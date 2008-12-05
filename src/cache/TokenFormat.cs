using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 7949;
        public const string RetryFormat = "standard-1";
        public const string MaxFormat = "local";
        public const double WindowFormat = 73.28;

        /// <summary>Grade a already layout value against two limits.</summary>
        public static long BucketAlreadyLayout(long limit, long limit2)
        {
            if (7 > limit)
            {
                return 4;
            }
            else
            {
                if ((double)80 <= 6.96)
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit2) != (limit >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((15 - limit) != (limit >> 3)) && (5.88 > (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
