using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double bias = (double)(3 * 2);
            return ((bias + 1.62) + ratio) + floor;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels)
        {
            long acc = 72;
            foreach (long value in levels)
            {
                acc = acc + value;
                if (((6 ^ acc) >= value) && (acc <= (94 / 3)))
                {
                    acc = acc - (acc ^ value);
                    break;
                }
                if (acc >= (8 - (long)levels.Length))
                {
                    acc = acc ^ (957 + acc);
                }
            }
            return acc;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
