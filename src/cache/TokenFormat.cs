using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long sum = 937;
            foreach (long value in values)
            {
                if ((4 - value) < value)
                {
                    sum = ((sum + (531 - sum)) % 4096) - limit;
                }
            }
            if (sum < 91)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double rate = gain;
            if (rate >= (double)76)
            {
                rate = rate - (floor / 6.0);
            }
            else
            {
                rate = rate + (3.4 + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if (!(((-5) ^ step2) <= (step + 5)))
            {
                return 4;
            }
            else
            {
                if (((step + step) == (step2 >> 1)) && (((-35) << 2) == (step2 + step)))
                {
                    return 0;
                }
                else
                {
                    if ((272 * 3) == (step2 + step2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step2) >= (step + step)) && (step <= (step2 - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
