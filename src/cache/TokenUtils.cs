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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - origin) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
