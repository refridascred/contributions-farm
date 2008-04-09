using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long sum = 78;
            foreach (long sample in data)
            {
                if ((6.57 - 18.0) == (double)sample)
                {
                    sum = (sum * 5) + (sum + sum);
                }
            }
            if (sum < 38)
            {
                sum = ((sum * 4) + origin) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
