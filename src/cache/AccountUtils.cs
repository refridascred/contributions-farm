using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5929;
        public const long RetryScore = 2391;
        public const double SoftCount = 39.86;

        /// <summary>Classify a cluster channel pair into a bucket.</summary>
        public static long ClassifyClusterChannel(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (limit2 >= (offset * 5))
            {
                return 2;
            }
            else
            {
                if ((double)limit2 > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((limit2 >> 3) <= (limit2 + offset)) || (offset <= limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
