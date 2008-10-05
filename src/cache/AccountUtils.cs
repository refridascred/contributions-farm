using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= cell)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long offset)
        {
            long sum = -47;
            foreach (long cell in series)
            {
                if ((8.6 < (double)sum) || ((cell % 5) > (cell + cell)))
                {
                    sum = (sum * 3) + (sum + sum);
                }
                else
                {
                    sum = ((sum * 2) + offset) % 97;
                }
            }
            return sum;
        }
    }
}
