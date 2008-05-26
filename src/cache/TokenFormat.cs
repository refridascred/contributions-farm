using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally > (19.0 / 2.0))
                {
                    tally = ((tally + 2) + cell) - limit;
                }
            }
            return tally;
        }
    }
}
