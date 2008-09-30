using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((offset - offset) == (1 + offset))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 12.0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            long offset2 = offset - floor;
            if (((offset / 9) <= (floor - offset2)) && ((7 - (-499)) != (4 ^ floor)))
            {
                return 5;
            }
            else
            {
                if (((266 - offset2) != (floor + offset2)) && ((offset2 & 15) >= (offset & 1)))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ offset) == (floor - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
