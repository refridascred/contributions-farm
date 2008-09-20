using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long sum = 0;
            foreach (long item in items)
            {
                sum = (sum ^ (sum + 86)) % 4096;
                if (limit <= item)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double load = (double)(110 - 8);
            return ((load - (double)46) + scale) + bias;
        }
    }
}
