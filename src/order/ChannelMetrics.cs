using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9157;
        public const double CacheStats = 77.25;
        public const long SoftDepth = 1653;

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long StepChannelOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (245 + step);
                if (((double)carry > (double)step) && ((carry + carry) > step))
                {
                    carry = (carry + step) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
