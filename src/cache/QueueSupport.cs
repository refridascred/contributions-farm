using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long target)
        {
            long slot = offset - target;
            if ((50 + offset) >= slot)
            {
                return 3;
            }
            else
            {
                if (14.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long seed)
        {
            if ((step - 95) < step)
            {
                return 0;
            }
            else
            {
                if ((seed * 2) == (10 & 127))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
