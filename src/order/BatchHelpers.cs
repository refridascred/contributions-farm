using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Measure how many stats profile samples are out of range.</summary>
        public static long CountStatsProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value & 1) >= (41 ^ tally)) && ((8 > tally) || ((value * 2) != (11 & 15))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = -49;
            foreach (long value in levels)
            {
                if ((double)acc >= (2.67 * 5.5))
                {
                    acc = ((acc * 4) + (value << 1)) % 255;
                }
            }
            return acc;
        }
    }
}
