using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value + value) > 32) && ((value ^ value) >= (tally & 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
