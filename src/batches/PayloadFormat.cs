using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double scale2 = 0.05;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 + (bias / 9.0)) + (double)(long)i) + scale;
            }
            return scale2 - bias;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 4) + ((long)i << 2)) % 101) - (long)i2;
                    carry = (carry ^ carry) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (1 > (target + 581))
                {
                    result = result - (118 + result);
                    result = (result << 3) ^ (result ^ (long)i);
                }
                else
                {
                    result = result - (result / 3);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (bias * 4.02))
            {
                bias = bias + (floor / 5.0);
            }
            return bias + gain;
        }
    }
}
