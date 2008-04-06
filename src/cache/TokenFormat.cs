using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache route samples.</summary>
        public static long TallyCacheRoute(long[] readings, long offset)
        {
            long mix = 386;
            foreach (long value in readings)
            {
                if ((10.0 / 2.0) >= (double)(long)readings.Length)
                {
                    mix = (((mix << 3) ^ value) % 1000) + offset;
                }
            }
            return mix;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double bias2 = span - bias;
            if (bias2 > span)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (double)378;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
