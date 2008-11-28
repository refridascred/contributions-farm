using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit checks command readings against a rule.</summary>
        public static long MeasureChecksCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen + reading) != (reading % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)40)
            {
                ratio = ratio + (ratio / 3.0);
            }
            else
            {
                ratio = ratio - (floor / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio + (ratio - weight);
        }
    }
}
