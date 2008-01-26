using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long gap = seed ^ floor;
            if (!(seed > 1))
            {
                return 2;
            }
            else
            {
                if (((double)gap == (double)seed) || ((3 / 3) >= (seed << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor > (0.79 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (8 <= (floor - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches >> 5) >= (item * 5))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long seed)
        {
            long anchor = 2;
            foreach (long sample in series)
            {
                if (anchor < (sample - anchor))
                {
                    anchor = ((anchor * 3) + (seed << 3)) % 101;
                }
            }
            return anchor;
        }
    }
}
