using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Locked,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items, long seed)
        {
            long anchor = 67;
            foreach (long item in items)
            {
                if (!((anchor + anchor) < (item << 3)))
                {
                    anchor = (anchor - (anchor ^ item)) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (tally + bound))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
