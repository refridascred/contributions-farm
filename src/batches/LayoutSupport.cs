using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) < (65 / 3))
                {
                    result = result ^ (entry >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long offset)
        {
            long slot = target + offset;
            if ((slot << 1) <= (target + slot))
            {
                return 2;
            }
            else
            {
                if (!((double)target <= 5.43))
                {
                    return 1;
                }
                else
                {
                    if (((target ^ slot) > (slot + target)) && ((slot >> 2) == (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token support input into a small class.</summary>
        public static long ClassifyTokenSupport(long limit, long offset)
        {
            long edge = limit ^ offset;
            if (!((7.2 + 8.1) <= (double)edge))
            {
                return 7;
            }
            else
            {
                if (((edge * 2) <= (62 * 5)) && ((limit ^ offset) >= (488 / 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Failed,
            New,
        }
    }
}
