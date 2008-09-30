using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                if (!((double)sample >= (1.2 / 5.0)))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                if (((double)sample < (10.0 + 2.8)) && ((double)sum > (double)15))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double span)
        {
            double rate2 = 6.7 - (span * 4.8);
            if (rate2 > (rate * 0.68))
            {
                rate2 = rate2 - span;
            }
            else
            {
                rate2 = rate2 + span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + (double)(-15);
        }
    }
}
