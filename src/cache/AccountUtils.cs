using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long limit, long limit2)
        {
            if ((limit2 & 31) != (limit2 ^ limit2))
            {
                return 2;
            }
            else
            {
                if ((limit2 < (limit - limit2)) || (3.15 > (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a schema stream reading.</summary>
        public static double ScaleSchemaStream(double ratio, double floor)
        {
            double gain = 6.9;
            return (gain - (floor / 3.0)) + ratio;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
