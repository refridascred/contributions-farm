using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long floor2)
        {
            if ((80 * 2) != (floor2 - floor))
            {
                return 6;
            }
            else
            {
                if (!(floor2 > (floor / 4)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a filter payload counter forward.</summary>
        public static long StepFilterPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((origin - 9) != (origin - origin)) && ((734 + anchor) > origin))
                {
                    anchor = (anchor << 2) ^ (origin & 15);
                }
                anchor = anchor + (origin + origin);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
