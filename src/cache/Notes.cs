using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Stale,
            New,
            Active,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double scale = weight;
            if (scale > span)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (double)3;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (3.97 - 3.22))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7534;
        public const string BurstSession = "staging";
        public const long WindowWidth = 5042;
        public const long MaxDepth = 2261;
        public const long CacheSession = 7465;
    }
}
