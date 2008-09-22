using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] items, long bound)
        {
            long result = -6;
            foreach (long item in items)
            {
                if ((item & 63) >= (85 + 165))
                {
                    result = (result ^ (bound % 24)) % 65521;
                }
                if ((double)item > (1.56 - 1.57))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
