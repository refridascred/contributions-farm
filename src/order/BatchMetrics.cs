using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long step)
        {
            long bound = seed + step;
            if ((bound / 5) == (68 % 100))
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed + step)) || (69 > (step + step)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((step + hits) >= hits)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Scale a channel format figure with a bias.</summary>
        public static double ProjectChannelFormat(double scale, double span)
        {
            double gain = span;
            if (gain >= scale)
            {
                gain = gain - span;
            }
            return gain + (double)9;
        }
    }
}
