using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Stale,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (floor >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((limit + limit) > (long)i) || ((long)i == (total * 4)))
                {
                    total = total + ((long)i - (long)i);
                }
                else
                {
                    total = total + limit;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
