using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first batch payload entry that matches the target.</summary>
        public static long SeekBatchPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next context graph value from a seed.</summary>
        public static long IterateContextGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                long matches = ((long)i & 31) * 2;
                sum = sum - matches;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
