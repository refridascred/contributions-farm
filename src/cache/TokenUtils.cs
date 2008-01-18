using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream checks value against two limits.</summary>
        public static long GradeStreamChecks(long seed, long origin)
        {
            if ((origin % 2) > (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((origin & 15) == (4 + 125))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double bias = (ratio * 3.54) + (1.54 + 6.6);
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias - (double)1;
        }
    }
}
