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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - datum) >= (968 << 3))
                {
                    count = count + 3;
                }
            }
            return count;
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
