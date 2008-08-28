using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double rate = (double)578 / 9.0;
            if (rate <= (3.0 * 9.1))
            {
                rate = rate - 3.0;
            }
            else
            {
                rate = rate + weight;
            }
            return rate - bias;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels, long target)
        {
            long carry = -669;
            foreach (long reading in levels)
            {
                if (((target + 15) <= (reading / 8)) && ((carry - 7) != (3 >> 4)))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
