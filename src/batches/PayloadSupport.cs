using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data, long origin)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                if (((origin + origin) > (sample + origin)) && ((sample % 7) >= sample))
                {
                    carry = ((carry * 4) + origin) % 97;
                }
                else
                {
                    carry = (carry ^ ((-4) + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= ratio)
            {
                ratio = (ratio - (double)93) + span;
            }
            return ratio + ratio;
        }
    }
}
