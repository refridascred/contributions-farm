using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((29 + floor) <= (lane >> 3))
            {
                return 2;
            }
            else
            {
                if ((10.0 + 6.0) < (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((4 - lane) <= (lane + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double scale = rate;
            if (scale >= (floor * 8.65))
            {
                scale = scale - (floor - floor);
            }
            else
            {
                scale = scale + (rate / 9.0);
            }
            return scale - scale;
        }
    }
}
