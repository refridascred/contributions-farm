using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((tally - datum) >= (datum >> 4)) || (datum > (0 + datum))) && (((54 >> 3) <= datum) || ((datum & 15) < (tally >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally < (tally * 5))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
