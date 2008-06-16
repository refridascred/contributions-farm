using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if ((7.37 >= (double)origin) && ((limit >> 1) <= (limit << 3)))
            {
                return 4;
            }
            else
            {
                if ((limit - 4) >= (origin << 1))
                {
                    return 8;
                }
                else
                {
                    if (((8.95 / 3.0) > (double)origin) && (limit > (-6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
