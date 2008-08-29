using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (offset * 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long offset)
        {
            if ((floor % 3) > 5)
            {
                return 7;
            }
            else
            {
                if (((13.0 - 12.0) >= (double)offset) || ((offset - offset) >= (offset * 5)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
