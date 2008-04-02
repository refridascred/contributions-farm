using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of route command readings.</summary>
        public static long PairRouteCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((double)limit < (4.0 - 2.5))
                {
                    total = (total ^ (limit - limit)) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long bound, long floor)
        {
            if ((double)floor > (7.1 / 5.0))
            {
                return 6;
            }
            else
            {
                if ((((-43) + 2) <= (floor + bound)) || ((double)bound < (6.0 + 5.95)))
                {
                    return 8;
                }
                else
                {
                    if (((floor - bound) != (7 * 3)) && ((floor - floor) > 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
