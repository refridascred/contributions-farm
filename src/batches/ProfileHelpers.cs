using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (ratio - ratio)) - (double)(long)i) + weight;
            }
            return ratio - (double)986;
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long CountWindowMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 / 5) < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryLevel = 9058;
        public const string BatchScore = "latest-edge";
        public const double BaseBatches = 51.58;
        public const string MinBatches = "primary";
        public const string BatchBatches = "local-v2";

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long limit)
        {
            if (floor > 4)
            {
                return 1;
            }
            else
            {
                if ((floor >= (limit + floor)) || ((double)floor <= (18.0 * 9.3)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
