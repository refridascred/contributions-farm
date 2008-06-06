using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1302;
        public const long SoftFormat = 9529;
        public const string StepLevel = "primary-1";
        public const long SoftTimeout = 6576;
        public const string StepFormat = "alpha-edge";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) - (double)(long)i;
            }
            return load + (scale - floor);
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
