using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((2 + tally) >= tally))
                {
                    tally = ((tally + 1) + entry) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double ratio = (double)(511 & 15);
            if (ratio > (ratio / 5.0))
            {
                ratio = (ratio - (ratio + floor)) + scale;
            }
            return ratio - floor;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            if (floor <= seed)
            {
                return 1;
            }
            else
            {
                if (seed >= floor)
                {
                    return 7;
                }
                else
                {
                    if (((91 - seed) > (floor % 3)) || ((seed / 6) <= (seed ^ seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
