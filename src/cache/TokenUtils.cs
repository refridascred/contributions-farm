using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 1380;
        public const double MaxPayload = 66.29;
        public const long IdlePayload = 3279;
        public const long DefaultBudget = 1106;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long limit)
        {
            long offset = bound - limit;
            if (((limit + 92) > (bound + bound)) || ((offset - bound) < (limit & 63)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)(-98))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
