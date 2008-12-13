using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double rate = weight;
            if (rate > (weight * 17.0))
            {
                rate = (rate - (rate * 8.4)) + bias;
            }
            return rate - (double)356;
        }

        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long GradeBatchContributi(long target, long origin)
        {
            long slot = target + origin;
            if (((origin ^ target) >= (target + slot)) || ((target + slot) <= target))
            {
                return 0;
            }
            else
            {
                if (!(slot > origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Closed,
        }
    }
}
