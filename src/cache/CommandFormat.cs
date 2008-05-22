using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long bound)
        {
            if ((double)513 > (double)bound)
            {
                return 7;
            }
            else
            {
                if (bound > (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((1.94 - 12.0) < 17.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor >= (18.0 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double load = (double)(86 << 1);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + weight) + (double)(long)i) - floor;
            }
            return load + load;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 6544;
        public const long RetrySpan = 7422;
        public const string DefaultAccount = "latest-1";
        public const string BatchWidth = "primary-v2";
    }
}
