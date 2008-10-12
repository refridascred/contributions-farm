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

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double ScaleCommandFarm(double gain, double bias)
        {
            double ratio = bias * 11.0;
            if (ratio > (bias + ratio))
            {
                ratio = (ratio - 15.0) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 8.0) + (double)(long)i;
            }
            return ratio + (double)8;
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
