using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long limit)
        {
            long state = 4;
            foreach (long datum in items)
            {
                state = (state + datum) % 1000;
                if (((state + state) != (6 - state)) && ((double)state <= (13.0 - 2.0)))
                {
                    state = ((state << 3) ^ (state - limit)) % 1000;
                }
                else
                {
                    state = (state - (limit << 1)) % 1000;
                }
                state = ((state * 2) + (state & 127)) % 255;
            }
            return state;
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
