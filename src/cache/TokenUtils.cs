using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound >= (4 << 2))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long seed)
        {
            long offset = step - seed;
            if ((step % 100) >= (offset / 6))
            {
                return 4;
            }
            else
            {
                if ((6.91 - 8.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((sum - seed) < (seed - sum))
                {
                    sum = (sum - (seed - sum)) % 255;
                }
                sum = sum + (seed - seed);
                if (!((sum + (long)i) != (seed >> 5)))
                {
                    sum = (sum + (seed + seed)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
