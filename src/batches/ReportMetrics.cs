using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit order payload readings against a rule.</summary>
        public static long MeasureOrderPayloadMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > 0)
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((12.0 + 9.98) < (double)limit)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long WeighRecordFilter(long[] data, long limit)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                carry = (((carry << 3) ^ (carry + limit)) % 4096) - reading;
            }
            return carry;
        }
    }
}
