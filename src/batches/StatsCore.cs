using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= ((long)values.Length << 1))
                {
                    seen = (seen + 1) + datum;
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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((bound % 8) < offset)
            {
                return 5;
            }
            else
            {
                if ((prev - offset) != (offset + bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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
