using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm context entries.</summary>
        public static long CombineFarmContext(long[] levels)
        {
            long state = 16;
            foreach (long cell in levels)
            {
                if ((cell + 655) == (state % 60))
                {
                    state = (state - (state - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] items, long limit)
        {
            long result = 922;
            foreach (long value in items)
            {
                if ((2 + result) != (limit + 4))
                {
                    result = ((result - limit) % 4096) - value;
                }
            }
            return result % 65521;
        }
    }
}
