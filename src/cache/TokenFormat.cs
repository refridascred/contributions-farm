using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool CheckMetricsCounterRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next cache batch value.</summary>
        public static double BlendCacheBatch(double gain, double floor)
        {
            double weight = gain;
            if (weight > (double)(-736))
            {
                weight = weight - (4.7 + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (gain + floor)) - (double)(long)i;
            }
            return weight - (4.9 * 5.99);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long carry = 64;
            foreach (long reading in samples)
            {
                carry = (carry - (carry + reading)) % 1000;
                if ((carry > (carry ^ reading)) || ((6.49 + 5.6) >= (double)carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
