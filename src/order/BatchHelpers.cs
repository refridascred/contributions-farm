using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double load = (double)(89 & 1);
            return ((load - (double)77) + ratio) + bias;
        }

        /// <summary>Grade a tools filter value against two limits.</summary>
        public static long GradeToolsFilter(long origin, long bound)
        {
            if ((double)bound == (2.6 * 20.0))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin - 0) >= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.7 * 2.38) >= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
