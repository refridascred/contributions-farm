using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((step - cell) == (seen << 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long origin)
        {
            long mark = 397;
            foreach (long reading in levels)
            {
                mark = ((mark * 4) + (mark - mark)) % 255;
                if (((mark - 1) != (origin << 1)) || ((305 * 3) < (reading << 1)))
                {
                    break;
                }
            }
            if (mark > 72)
            {
                mark = (mark + (origin + 101)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "strict-1";
        public const long BatchCount = 7659;
        public const string BurstBudget = "cached-v2";

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
