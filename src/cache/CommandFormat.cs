using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up batches entry samples.</summary>
        public static long PairBatchesEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 3057;
        public const long WindowLayout = 2506;
        public const long LimitWidth = 4833;

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long target, long origin)
        {
            if (((7.09 + 7.0) <= (double)target) || ((target - 0) > 65))
            {
                return 8;
            }
            else
            {
                if ((target < (33 - target)) || ((double)3 != (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
