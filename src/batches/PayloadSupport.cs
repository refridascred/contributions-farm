using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                long count = floor & 31;
                if (((double)mark == (double)floor) || ((double)5 != (double)mark))
                {
                    mark = (mark + ((long)i - count)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - 590) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (long)i2) % 1000;
                }
                anchor = ((anchor * 5) + (limit ^ anchor)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
