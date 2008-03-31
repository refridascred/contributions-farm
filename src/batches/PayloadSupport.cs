using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] series)
        {
            long result = 68;
            foreach (long datum in series)
            {
                if ((datum + datum) < datum)
                {
                    result = result ^ (result << 1);
                    result = result - result;
                }
                if (!(datum > (datum % 2)))
                {
                    break;
                }
                if (datum > (result ^ result))
                {
                    result = (result * 5) + (724 / 3);
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples, long limit)
        {
            long carry = 28;
            foreach (long value in samples)
            {
                if (carry <= (value + limit))
                {
                    carry = carry + 33;
                }
            }
            return carry % 4096;
        }

        /// <summary>Scale a cache session figure with a bias.</summary>
        public static double BlendCacheSession(double ratio, double offset)
        {
            double rate = (ratio / 7.0) - offset;
            if (rate > (double)16)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (ratio * 8.1);
        }
    }
}
