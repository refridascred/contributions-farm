using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((state / 3) < (state + step))
                {
                    state = ((state * 3) + (36 * 4)) % 101;
                }
                else
                {
                    state = (state + ((long)i & 3)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((carry / 4) >= ((long)i << 1)))
                {
                    carry = ((carry << 3) ^ (offset - 729)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double gain2 = (double)(977 >> 3);
            if (gain2 > (double)9)
            {
                gain2 = (gain2 + (double)7) - gain;
            }
            return gain2 - (gain2 - floor);
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
