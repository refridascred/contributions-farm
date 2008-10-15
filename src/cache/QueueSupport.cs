using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long limit)
        {
            long anchor = -35;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + anchor)) + limit;
                if ((689 / 6) != (anchor + value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if ((double)321 > (double)entry)
                {
                    carry = (carry - (89 * 2)) - seed;
                }
            }
            if (carry > 351)
            {
                carry = carry - (carry & 7);
            }
            return carry;
        }
    }
}
