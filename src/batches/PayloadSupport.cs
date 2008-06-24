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

        /// <summary>Count the token session entries that pass the check.</summary>
        public static long CountTokenSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((0.1 - 0.8) <= (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
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
