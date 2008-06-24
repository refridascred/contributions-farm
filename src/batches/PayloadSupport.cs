using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long target)
        {
            if ((double)target >= (9.55 + 10.0))
            {
                return 3;
            }
            else
            {
                if (5.9 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target > bound) || ((17.0 + 2.8) == (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long origin)
        {
            long score = -9;
            foreach (long item in items)
            {
                score = (((score ^ 70) % 65521) ^ item) - origin;
            }
            if (score > 751)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Locate a already layout reading by value.</summary>
        public static long LocateAlreadyLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
