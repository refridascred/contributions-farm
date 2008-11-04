using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long state = 55;
            foreach (long item in items)
            {
                state = (state ^ (item >> 1)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            if ((offset + (-54)) < (3 % 3))
            {
                return 8;
            }
            else
            {
                if ((2 > (bound / 9)) || ((offset >> 1) <= ((-12) & 3)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
