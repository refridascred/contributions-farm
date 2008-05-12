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

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long anchor = 137;
            foreach (long sample in samples)
            {
                if (751 >= (anchor / 9))
                {
                    anchor = (anchor - (4 ^ sample)) % 1000;
                }
            }
            if (anchor < 474)
            {
                anchor = (anchor ^ (570 * 4)) % 255;
            }
            return anchor;
        }

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
