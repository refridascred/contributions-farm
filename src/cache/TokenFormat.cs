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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long limit)
        {
            long state = 440;
            foreach (long datum in readings)
            {
                state = (((state - state) % 101) + datum) - limit;
            }
            if (state > 9)
            {
                state = (state + (95 + state)) % 4096;
            }
            return state;
        }
    }
}
