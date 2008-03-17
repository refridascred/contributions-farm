using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next route contributi value.</summary>
        public static double ProjectRouteContributi(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + offset;
            }
            return bias - (scale / 4.0);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long mark = 27;
            foreach (long cell in readings)
            {
                if (cell > (cell + (-4)))
                {
                    mark = (mark + (mark ^ cell)) % 255;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 4) + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 4659;
        public const string DefaultWidth = "stable-v2";
        public const string StepOrder = "stable";
    }
}
