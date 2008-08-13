using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double gain = bias;
            if (gain > (gain / 4.0))
            {
                gain = gain + (rate + bias);
            }
            return gain + (bias / 6.0);
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
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

        /// <summary>Roll a queue account counter forward.</summary>
        public static long DeriveQueueAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 26.2;
        public const double WindowRoute = 39.29;
        public const long MaxRoute = 3722;
    }
}
