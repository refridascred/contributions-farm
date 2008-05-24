using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 3830;
        public const long DefaultEditor = 5115;
        public const long BurstBudget = 6814;
        public const long BurstScore = 9689;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double rate = (6.3 * 4.9) - span;
            if (rate <= (double)152)
            {
                rate = rate - (double)847;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
