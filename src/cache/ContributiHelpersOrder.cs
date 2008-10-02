using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long carry = 510;
            foreach (long entry in items)
            {
                carry = ((carry * 2) + (entry / 6)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (31 >= (hits - origin))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long TallyStreamMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 1) != ((long)values.Length * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
