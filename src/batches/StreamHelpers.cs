using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4.68 - 4.9) < (double)tally)
                {
                    tally = ((tally + 1) ^ item) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultTimeout = 1167;
        public const long BaseSpan = 491;
        public const long DefaultFormat = 4414;
        public const double DefaultDepth = 14.41;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((7.27 - 12.0) != (double)tally) && (((-51) - tally) > (target - tally)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
