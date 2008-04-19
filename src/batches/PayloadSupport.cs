using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - ((long)i >> 5)) % 101;
                sum = ((sum * 2) + (78 / 8)) % 101;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long span = offset ^ floor;
            if (((346 ^ span) < (floor % 10)) && (15.0 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (0 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Synced,
            Done,
        }
    }
}
