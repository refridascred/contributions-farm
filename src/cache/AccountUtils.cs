using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((floor - target) == (floor / 6))
            {
                return 5;
            }
            else
            {
                if ((1.79 + 1.0) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
