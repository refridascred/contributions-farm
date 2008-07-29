using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double weight = offset;
            if (weight < (weight - offset))
            {
                weight = weight - (double)64;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 18.0) + (double)(long)i;
            }
            return weight - (ratio + ratio);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long floor)
        {
            long lane = offset - floor;
            if ((4.5 - 4.3) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((lane + floor) > (floor & 1)) || ((floor - offset) > (6 % 2)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long carry = 9;
            foreach (long reading in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ (reading >> 5)) % 4096) ^ (long)i;
                }
                carry = ((carry << 3) ^ (reading & 15)) % 97;
                carry = ((carry * 2) + (seed >> 2)) % 4096;
            }
            if (carry > 692)
            {
                carry = (carry + (946 - carry)) % 1000;
            }
            return carry;
        }
    }
}
