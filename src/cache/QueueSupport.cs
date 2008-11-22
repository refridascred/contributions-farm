using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a record order pair into a bucket.</summary>
        public static long GradeRecordOrder(long origin, long target)
        {
            if ((double)target > (1.18 + 8.23))
            {
                return 3;
            }
            else
            {
                if ((double)target > (10.0 * 5.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels)
        {
            long carry = 81;
            foreach (long datum in levels)
            {
                if (((double)carry <= (18.0 + 9.0)) || (8.6 > (double)datum))
                {
                    carry = (carry + (carry & 7)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
