using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (88 - hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
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
