using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift >= floor)
            {
                drift = drift - (rate / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift * 0.13)) + (double)(long)i;
            }
            return drift - (floor / 6.0);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order account readings.</summary>
        public static long TallyOrderAccount(long[] series, long bound)
        {
            long sum = -946;
            foreach (long reading in series)
            {
                if (reading <= (bound + sum))
                {
                    sum = sum ^ (bound * 2);
                }
                if (sum > bound)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
