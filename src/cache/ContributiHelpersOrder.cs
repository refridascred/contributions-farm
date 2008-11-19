using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long limit, long target)
        {
            long gap = limit - target;
            if (((-92) - limit) > gap)
            {
                return 7;
            }
            else
            {
                if ((gap >> 1) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
