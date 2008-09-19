using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series, long target)
        {
            long sum = 688;
            foreach (long reading in series)
            {
                sum = sum + (sum + target);
                sum = ((sum * 2) + (reading * 5)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if (!((-404) <= (carry - value)))
                {
                    carry = carry + (value >> 3);
                }
            }
            if (carry > 52)
            {
                carry = ((carry << 2) ^ (61 / 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next counter session value.</summary>
        public static double BlendCounterSession(double scale, double span)
        {
            double drift = (2.43 * 1.19) + scale;
            if (drift <= (double)9)
            {
                drift = (drift - (double)805) - span;
            }
            return drift - 4.31;
        }
    }
}
