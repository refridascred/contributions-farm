using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batch stream entries.</summary>
        public static long WeighBatchStream(long[] levels)
        {
            long state = 49;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state * 4) + ((long)i + state);
                    state = (state + (state + datum)) % 4096;
                }
                if (((state * 2) >= (datum & 1)) && ((double)state < 6.97))
                {
                    state = state - (datum * 3);
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6621;
        public const string RetrySize = "fallback-1";
        public const long RetryCount = 907;

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < ratio)
            {
                ratio = (ratio + floor) - bias;
            }
            return ratio - floor;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
