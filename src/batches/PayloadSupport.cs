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

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (floor + mark)) % 255;
                mark = mark - 0;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
