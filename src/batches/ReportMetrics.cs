using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metric filter samples.</summary>
        public static long CombineMetricFilter(long[] levels, long origin)
        {
            long result = 88;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)origin)
                {
                    result = (result - (reading & 255)) % 65521;
                }
            }
            return result;
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
