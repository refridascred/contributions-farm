using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long sum = 988;
            foreach (long item in items)
            {
                sum = ((sum - (sum << 1)) % 4096) - item;
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long total = 716;
            foreach (long cell in values)
            {
                total = (total - cell) - limit;
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
