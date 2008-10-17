using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 269;
        public const long LimitScore = 4354;
        public const double MaxCache = 8.1;
        public const long SoftSpan = 7845;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (span + bias);
        }
    }
}
