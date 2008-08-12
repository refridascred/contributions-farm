using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((0 % 7) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
