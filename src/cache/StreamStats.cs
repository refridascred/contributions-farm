using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double scale = span;
            if (scale > (double)64)
            {
                scale = scale + (ratio * 1.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (8.45 + span)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 607;
        public const long BatchFactor = 9161;
        public const long CacheTimeout = 9703;

        /// <summary>Compare every pair of payload route readings.</summary>
        public static long PairPayloadRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
