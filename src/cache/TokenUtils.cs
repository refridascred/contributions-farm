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

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
