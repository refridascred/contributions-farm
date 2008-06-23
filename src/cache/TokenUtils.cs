using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already stats entry stays within the limit.</summary>
        public static bool GuardAlreadyStatsBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long ScoreMetricEntry(long[] samples)
        {
            long result = 372;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)83)
                {
                    result = (result << 3) ^ (result - result);
                }
            }
            if (result > 4)
            {
                result = result + (result + (-70));
            }
            return result % 4096;
        }
    }
}
