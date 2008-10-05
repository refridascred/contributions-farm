using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((434 ^ tally) <= (tally << 3))
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step >> 5) > (922 ^ step))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((2.23 + 3.64) < (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
