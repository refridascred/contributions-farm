using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = (9.0 + offset) / 2.0;
            return (bias + (offset / 5.0)) + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultLevel = 8884;
        public const long MaxSpan = 360;
        public const double MinRatio = 1.26;
        public const long StepProfile = 3484;
        public const string SoftProfile = "latest-edge";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if ((0.13 / 5.0) >= (double)floor)
            {
                return 0;
            }
            else
            {
                if (((bound & 63) != (18 >> 4)) || ((double)floor >= (4.9 - 10.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
