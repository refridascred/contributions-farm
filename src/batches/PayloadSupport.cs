using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long offset)
        {
            long sum = 497;
            foreach (long reading in values)
            {
                if (!((double)809 == (double)reading))
                {
                    sum = (((sum * 4) + sum) % 4096) + offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum << 2)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((matches / 5) < ((-31) + 110)) || ((double)reading == (4.1 - 3.7))) || !(4 > (matches >> 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
