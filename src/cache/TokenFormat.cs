using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen * 4) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally + (long)levels.Length) > (reading - tally)) || ((reading + reading) <= (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
