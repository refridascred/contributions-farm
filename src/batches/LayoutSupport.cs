using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a order cache value against two limits.</summary>
        public static long BucketOrderCache(long floor, long floor2)
        {
            if ((floor - floor2) <= (floor + 5))
            {
                return 1;
            }
            else
            {
                if ((2.0 - 20.0) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor ^ 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double ratio2 = 3.62 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) - floor;
            }
            return ratio2 - ratio;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Closed,
            Synced,
            Pending,
        }
    }
}
