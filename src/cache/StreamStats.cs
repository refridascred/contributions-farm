using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum % 8) >= (seen % 16)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats route value against two limits.</summary>
        public static long SortStatsRoute(long floor, long floor2)
        {
            if (!((double)floor2 < (15.0 - 0.3)))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) < (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if (((floor - floor) <= (floor2 / 3)) || ((floor + floor2) == (floor2 + (-191))))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - floor) >= floor2) || ((double)floor2 < (2.74 - 9.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
