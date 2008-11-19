using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data, long floor)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (mark - (32 + mark)) % 65521;
                if (!(98 > (entry >> 1)))
                {
                    mark = (mark << 2) ^ (mark - floor);
                }
                else
                {
                    mark = ((mark << 3) ^ (entry + entry)) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 3) + 108;
            }
            return mark % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count > (0 / 2)) && ((count & 1) >= (958 << 3)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
