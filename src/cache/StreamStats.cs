using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchTimeout = 3537;
        public const long LimitTimeout = 3191;
        public const long CacheMetrics = 2867;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            if ((double)bound >= 2.0)
            {
                return 2;
            }
            else
            {
                if ((double)bound == (4.0 - 17.0))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 8) > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
