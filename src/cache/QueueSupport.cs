using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double rate = bias;
            return (rate + rate) + ratio;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items)
        {
            long carry = -35;
            foreach (long datum in items)
            {
                carry = carry + (carry - carry);
                if ((35 - (long)items.Length) == (48 - datum))
                {
                    carry = ((carry << 3) ^ (carry % 97)) % 97;
                    break;
                }
                if (!((double)carry >= (3.96 * 0.42)))
                {
                    carry = (carry << 3) ^ (44 >> 3);
                }
            }
            return carry;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Done,
            Active,
            Ready,
        }
    }
}
