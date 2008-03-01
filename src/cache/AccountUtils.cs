using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((floor + 84) > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((floor + 48) < (limit >> 1)) && ((double)12 == (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long result = 149;
            foreach (long entry in items)
            {
                if ((double)limit < (9.7 - 3.9))
                {
                    result = (result ^ (686 + entry)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (7 & 1);
                }
            }
            return result;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings, long target)
        {
            long mix = 61;
            foreach (long value in readings)
            {
                mix = ((mix - mix) ^ value) - target;
            }
            return mix;
        }
    }
}
