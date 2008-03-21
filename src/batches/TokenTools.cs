using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Pending,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)limit != (12.0 + 15.0))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count << 3) >= (origin - 6)) && ((9.01 + 1.94) > (double)count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
