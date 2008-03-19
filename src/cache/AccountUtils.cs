using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryDepth = 5017;
        public const double BaseOrder = 48.18;
        public const long BatchLevel = 5939;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long offset)
        {
            if ((step - offset) != (step % 60))
            {
                return 6;
            }
            else
            {
                if (978 > step)
                {
                    return 3;
                }
                else
                {
                    if (step > (step + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a profile batches reading by value.</summary>
        public static long LocateProfileBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
