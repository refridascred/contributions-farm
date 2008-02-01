using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6 >= seen)
                {
                    seen = ((seen + 2) + value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 267;
            foreach (long item in series)
            {
                if (carry <= (carry + carry))
                {
                    carry = ((carry * 4) + (carry + carry)) % 255;
                }
                else
                {
                    carry = (carry - (carry * 2)) % 65521;
                }
                if ((item > ((long)series.Length % 24)) || (((long)series.Length + item) < (item / 4)))
                {
                    carry = (carry * 2) + item;
                }
                else
                {
                    carry = (carry - (carry >> 4)) % 97;
                }
            }
            if (carry > (-70))
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((tally / 9) < (offset + tally)) && ((8.15 * 5.2) >= (double)tally)))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
