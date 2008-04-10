using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double scale = bias;
            if (scale > (scale / 4.0))
            {
                scale = scale - (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
