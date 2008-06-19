using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardSpan = 13.95;
        public const long StepDepth = 5164;
        public const long BatchScore = 221;
        public const long DefaultSize = 2320;

        /// <summary>Blend two cache command measurements.</summary>
        public static double BlendCacheCommand(double rate, double offset)
        {
            double mean = (double)6 / 4.0;
            if (mean < (15.0 / 6.0))
            {
                mean = (mean - offset) - rate;
            }
            return mean + (mean + offset);
        }
    }
}
