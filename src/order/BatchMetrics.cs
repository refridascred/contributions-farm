using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Pending,
            Done,
            Failed,
            Draft,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double load = weight;
            if (load > (double)958)
            {
                load = load - (8.2 + 8.4);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - (floor + weight);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3836;
        public const string CacheSpan = "alpha-edge";
        public const long DefaultWindow = 7257;
        public const double BurstWindow = 8.31;
        public const long RetryTimeout = 8702;
    }
}
