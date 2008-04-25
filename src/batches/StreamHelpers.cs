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

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long offset)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= state)
                {
                    state = (state - (offset + 19)) % 1000;
                }
            }
            return state % 97;
        }

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
