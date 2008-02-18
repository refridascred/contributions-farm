using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= 15.0)
            {
                scale = (scale - (scale * 2.0)) - offset;
            }
            else
            {
                scale = scale - (scale + scale);
            }
            return scale - 10.0;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total << 2) ^ bound) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
