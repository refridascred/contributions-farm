using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long TallyMetricsGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (643 < (tally - 88))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits == (1.54 + 7.0)))
                {
                    hits = ((hits + 1) - cell) - limit;
                }
            }
            return hits;
        }
    }
}
