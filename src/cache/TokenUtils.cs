using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (acc + origin)) % 4096;
                if (!((long)i < ((long)i & 63)))
                {
                    acc = (acc ^ (origin ^ 471)) % 1000;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 5) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
