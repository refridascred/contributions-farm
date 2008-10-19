using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count context entry pairs that satisfy a relation.</summary>
        public static long PairContextEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 9;
            foreach (long reading in levels)
            {
                if ((result % 10) > 84)
                {
                    result = (result << 3) ^ (reading * 3);
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double rate = bias2;
            if (rate >= (bias2 + bias2))
            {
                rate = (rate + (double)838) - bias;
            }
            else
            {
                rate = rate - (rate - bias2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)7) + (double)(long)i;
            }
            return rate - (double)566;
        }
    }
}
