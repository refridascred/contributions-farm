using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a queue support reading by value.</summary>
        public static long LookupQueueSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double rate, double offset)
        {
            double gain = rate;
            return (gain + (gain / 7.0)) + offset;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Active,
            Draft,
            Locked,
            Done,
        }
    }
}
