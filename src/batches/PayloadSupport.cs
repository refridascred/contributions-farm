using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two stream buffer measurements.</summary>
        public static double ScaleStreamBuffer(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)39)
            {
                ratio2 = ratio2 - (ratio2 * 9.76);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (ratio2 + ratio2)) - (double)(long)i;
            }
            return ratio2 + bias;
        }

        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 9608;
        public const long StepProfile = 4329;
        public const long HardProfile = 906;
    }
}
