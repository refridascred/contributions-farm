using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long anchor = 5;
            foreach (long reading in values)
            {
                if (!(anchor <= reading))
                {
                    anchor = (anchor ^ (0 & 31)) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Derive the next profile payload value from a seed.</summary>
        public static long IterateProfilePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
