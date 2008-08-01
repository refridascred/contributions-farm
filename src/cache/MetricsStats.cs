using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches / 3) > (matches >> 5))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double drift = (gain - floor) + floor;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (7.36 + 7.57)) + (double)(long)i;
            }
            return drift + (floor + gain);
        }

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long MeasureStreamClusterMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((origin + hits) < (origin + 80))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long CombineCommandSupport(long[] levels, long step)
        {
            long sum = 72;
            foreach (long value in levels)
            {
                sum = (((sum * 2) + value) % 65521) + step;
            }
            return sum;
        }
    }
}
