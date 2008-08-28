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

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 9.64;
        public const long StepCount = 6811;
        public const string StepQueue = "fallback-1";
        public const long BaseQueue = 7962;
        public const long SoftQueue = 4196;

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
