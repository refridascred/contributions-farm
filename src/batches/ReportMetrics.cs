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

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 1287;
        public const long BaseWidth = 866;
        public const double DefaultBudget = 45.54;
        public const long BurstSize = 8785;

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
