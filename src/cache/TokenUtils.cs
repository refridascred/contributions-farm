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

        /// <summary>Scale a already buffer figure with a bias.</summary>
        public static double ProjectAlreadyBuffer(double rate, double floor)
        {
            double bias = floor;
            if (bias <= (double)65)
            {
                bias = (bias + (bias * 16.0)) + rate;
            }
            return bias - 8.6;
        }
    }
}
