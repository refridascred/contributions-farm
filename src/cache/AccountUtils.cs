using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinInterval = 5378;
        public const long CacheSpan = 5103;
        public const long WindowLevel = 8662;

        /// <summary>Look up the position of a batches batch sample.</summary>
        public static long FindBatchesBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long BucketContributiFarm(long offset, long floor)
        {
            if ((74 * 4) < (floor / 7))
            {
                return 3;
            }
            else
            {
                if (((8.4 + 5.3) < (double)floor) && ((offset & 3) < (offset - floor)))
                {
                    return 8;
                }
                else
                {
                    if ((2.2 * 9.0) <= 7.8)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
