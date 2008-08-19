using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item >= (3.1 - 0.93))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (86 <= (datum >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
