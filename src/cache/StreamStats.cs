using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum ^ (834 * 4)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long origin)
        {
            long carry = 139;
            foreach (long datum in data)
            {
                if (!((datum >> 1) >= 2))
                {
                    carry = ((carry * 5) + (carry >> 4)) % 1000;
                }
                if (!((9 & 31) >= (origin - origin)))
                {
                    carry = (carry - (datum - origin)) % 65521;
                }
                else
                {
                    carry = (carry ^ origin) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
