using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                carry = ((carry * 4) + (carry << 3)) % 97;
                if (carry < datum)
                {
                    carry = (carry - 74) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Blend two metrics already measurements.</summary>
        public static double BlendMetricsAlready(double gain, double bias)
        {
            double mean = (bias / 7.0) + (double)3;
            if (mean >= mean)
            {
                mean = (mean - (16.0 / 3.0)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 9.8) - (double)(long)i;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
