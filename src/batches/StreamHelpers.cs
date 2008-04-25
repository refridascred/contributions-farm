using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double offset)
        {
            double rate = (bias - offset) - (double)0;
            return rate + rate;
        }

        /// <summary>Measure how many layout order samples are out of range.</summary>
        public static long TallyLayoutOrderHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((2.75 - 12.0) == (double)(long)values.Length) || ((item << 3) < item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Pending,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 58.7;
        public const double MinSpan = 29.4;
        public const long CacheSpan = 905;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long limit2)
        {
            if ((7 / 5) != (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((limit > (limit + limit)) || ((limit + limit) > (limit + 7)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
