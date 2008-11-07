using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stats context series from a seed.</summary>
        public static long DeriveStatsContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (seed >> 1)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double ratio = floor - floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (ratio - floor)) + (double)(long)i) - bias;
            }
            return ratio - (ratio / 9.0);
        }
    }
}
