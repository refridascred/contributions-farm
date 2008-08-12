using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseBudget = 4294;
        public const double LimitSession = 35.95;
        public const double MinSession = 70.9;
        public const long MaxSession = 6068;
        public const string BaseSession = "strict-1";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long target)
        {
            long bound = floor + target;
            if ((target & 31) <= (floor + target))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound > (double)floor))
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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!(285 >= limit))
                {
                    total = total + limit;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
