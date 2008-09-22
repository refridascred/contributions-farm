using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double scale = (3.0 * 13.0) + (ratio / 6.0);
            return (scale - (scale + ratio)) + floor;
        }

        /// <summary>Digest a series of commits support entries.</summary>
        public static long ScoreCommitsSupport(long[] data, long step)
        {
            long anchor = 32;
            foreach (long value in data)
            {
                if ((anchor >> 3) < (value ^ value))
                {
                    anchor = (anchor << 3) ^ 5;
                }
            }
            if (anchor > 95)
            {
                anchor = anchor + (step - anchor);
            }
            return anchor;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double ratio2 = 6.5 * 6.6;
            if (ratio2 >= (10.0 + ratio))
            {
                ratio2 = ratio2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio + ratio)) + (double)(long)i;
            }
            return ratio2 - (double)(-74);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
