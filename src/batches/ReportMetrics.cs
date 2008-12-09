using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = (carry << 2) ^ (carry - entry);
            }
            return carry;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
