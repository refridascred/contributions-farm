using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 2) + (long)i;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double mean = span * 15.0;
            return (mean - (span * 6.0)) + gain;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum * 3) + seed;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
