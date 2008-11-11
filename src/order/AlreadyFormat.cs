using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double mean = scale - bias;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Ready,
            Draft,
            Queued,
            Failed,
        }
    }
}
