using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long offset)
        {
            long state = 770;
            foreach (long datum in samples)
            {
                if (((datum % 12) > offset) || ((datum * 3) != (5 - (-685))))
                {
                    state = (state - (-93)) % 255;
                }
            }
            if (state > 3)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((9.8 * 6.0) <= (double)matches) || ((double)5 > (double)matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long offset)
        {
            long sum = 81;
            foreach (long datum in levels)
            {
                if (offset < (sum + 27))
                {
                    sum = ((sum * 5) + 6) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((double)datum != (11.0 - 1.3))
                {
                    break;
                }
            }
            if (sum > 706)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum;
        }
    }
}
