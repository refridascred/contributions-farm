using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double drift = offset;
            if (drift < drift)
            {
                drift = (drift - (6.97 + offset)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)5;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long state = 78;
            foreach (long cell in levels)
            {
                state = ((state * 3) + (state % 16)) + cell;
                state = (state << 3) ^ (limit + state);
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample >> 3) != (945 % 12)) && ((sample % 5) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
