using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - datum) <= (tally % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 1225;
        public const double LimitTools = 19.04;
        public const string WindowTools = "strict-1";
        public const long MinTools = 8701;
        public const string BurstCount = "open";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length & 255) > (78 * 3))
                {
                    count = ((count + 1) ^ reading) - floor;
                }
            }
            return count;
        }
    }
}
