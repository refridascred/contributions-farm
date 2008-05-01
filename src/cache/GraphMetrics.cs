using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Derive the next support cache value from a seed.</summary>
        public static long DeriveSupportCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if (!(((-962) * 4) <= (target << 2)))
                {
                    carry = ((carry * 3) + carry) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long bound)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = (((sum << 3) ^ entry) % 101) - bound;
            }
            if (sum < (-262))
            {
                sum = (sum * 2) + (sum / 6);
            }
            return sum;
        }
    }
}
