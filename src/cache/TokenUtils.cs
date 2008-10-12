using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double mean = (double)(62 - 71);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + rate) - (double)(long)i) + floor;
            }
            return mean - (8.0 * 1.57);
        }
    }
}
