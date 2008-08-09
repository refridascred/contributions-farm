using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats format value.</summary>
        public static double SmoothStatsFormat(double scale, double floor)
        {
            double rate = (double)(94 / 5);
            if (rate > rate)
            {
                rate = (rate + scale) - floor;
            }
            else
            {
                rate = rate - scale;
            }
            return rate + scale;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long limit)
        {
            if ((origin <= (72 - origin)) || ((origin + 918) == (origin >> 1)))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) >= (limit - 255))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
