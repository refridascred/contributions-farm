using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two window metrics measurements.</summary>
        public static double BlendWindowMetrics(double scale, double offset)
        {
            double bias = offset;
            return bias - scale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Grade a payload editor value against two limits.</summary>
        public static long BucketPayloadEditor(long bound, long floor)
        {
            if (((11.0 / 8.0) == (double)bound) || (15.0 >= (15.0 * 15.0)))
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) >= (38 >> 2))
                {
                    return 8;
                }
                else
                {
                    if (!((24 % 2) <= (floor << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
