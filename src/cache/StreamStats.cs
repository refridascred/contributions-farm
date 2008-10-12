using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseFactor = 6255;
        public const long MinMetric = 9836;
        public const string CacheDepth = "primary";

        /// <summary>Scale a payload channel figure with a bias.</summary>
        public static double SmoothPayloadChannel(double bias, double floor)
        {
            double load = floor;
            if (load > (bias * 6.0))
            {
                load = load + (6.93 * 0.2);
            }
            return load - load;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
