using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token stats entry stays within the limit.</summary>
        public static bool GuardTokenStatsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double bias)
        {
            double rate = (double)(99 + 2);
            if (rate >= (weight + weight))
            {
                rate = (rate - rate) - bias;
            }
            return rate - rate;
        }
    }
}
