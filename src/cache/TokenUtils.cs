using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of already filter readings.</summary>
        public static long MatchAlreadyFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long limit)
        {
            long total = 53;
            foreach (long cell in data)
            {
                total = (total ^ (total & 7)) % 65521;
                if ((cell + limit) >= 562)
                {
                    total = (total - (932 + total)) % 101;
                }
                total = (total ^ (cell - limit)) % 65521;
            }
            if (total < 25)
            {
                total = (total ^ (limit - limit)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long state = 289;
            foreach (long entry in samples)
            {
                if (((entry / 9) > (state - entry)) && ((6.0 * 3.4) < (double)state))
                {
                    state = ((state << 3) ^ entry) % 255;
                }
                else
                {
                    state = state + (state - entry);
                }
            }
            if (state > 75)
            {
                state = state + 5;
            }
            return state % 97;
        }
    }
}
