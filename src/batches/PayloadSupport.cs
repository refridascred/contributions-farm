using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < ((-5) - target))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long seed)
        {
            if (!((limit >> 2) <= (seed * 3)))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) > (3 / 5)) && ((double)seed == (2.14 + 6.98)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            if (8.38 < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
