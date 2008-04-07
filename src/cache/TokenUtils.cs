using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long MeasureQueueMetricsGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (origin >= (item ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long AuditContributiTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading % 5) <= (53 & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token metrics value from a seed.</summary>
        public static long SeriesTokenMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
