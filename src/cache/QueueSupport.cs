using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a entry metrics counter forward.</summary>
        public static long SeriesEntryMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + 44) != (seed - (long)i))
                {
                    carry = ((carry << 2) ^ (seed & 15)) % 255;
                }
                carry = (carry - (seed - seed)) % 4096;
                if ((((long)i >> 2) <= (carry ^ 34)) || ((double)(long)i == (1.4 + 7.0)))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double bias)
        {
            double load = (double)63;
            if (load <= load)
            {
                load = (load + (5.22 + weight)) - bias;
            }
            else
            {
                load = load - (double)919;
            }
            return load + weight;
        }
    }
}
