using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 3.58;
        public const double BurstScore = 19.1;
        public const long IdleBudget = 2336;
        public const long MinBatches = 828;
        public const long BatchTimeout = 5672;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double gain = (double)((-33) * 2);
            return ((gain - (double)259) + weight) + bias;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double scale, double span)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (3.54 * 9.32)) - (double)(long)i;
            }
            return bias + (span / 9.0);
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
