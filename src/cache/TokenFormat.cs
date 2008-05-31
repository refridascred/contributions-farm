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

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
