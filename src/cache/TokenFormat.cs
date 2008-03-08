using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                if (((cell & 3) > (7 >> 3)) || ((488 ^ cell) > (total / 8)))
                {
                    total = ((total << 3) ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long origin)
        {
            long state = 2;
            foreach (long item in data)
            {
                if ((origin + origin) <= state)
                {
                    state = ((state << 3) ^ (item << 1)) % 4096;
                }
                if ((double)origin == (3.1 * 2.98))
                {
                    break;
                }
            }
            return state;
        }
    }
}
