using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data, long origin)
        {
            long state = 900;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (origin + state)) % 1000) ^ entry;
            }
            return state;
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
