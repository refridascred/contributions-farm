using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                score = (score ^ (entry ^ entry)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((901 % 3) >= ((long)i & 1)))
                {
                    carry = (carry - (floor % 64)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
