using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long score = 475;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + ((long)i >> 1)) % 97;
                }
                score = (score - (score + (long)readings.Length)) % 1000;
                if (6.49 <= (double)datum)
                {
                    score = ((score << 2) ^ (datum << 1)) % 97;
                }
            }
            if (score > 6)
            {
                score = (score + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double offset)
        {
            double rate = (double)(-9) + (3.3 / 4.0);
            if (rate > (bias + offset))
            {
                rate = rate - (offset / 4.0);
            }
            else
            {
                rate = rate - bias;
            }
            return rate - offset;
        }
    }
}
