using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((5 < (matches + floor)) || ((floor - floor) < (cell & 127))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token editor samples are out of range.</summary>
        public static long AuditTokenEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + tally) <= datum) || ((datum * 3) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate tools checks readings against a bound.</summary>
        public static bool CheckToolsChecksLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
