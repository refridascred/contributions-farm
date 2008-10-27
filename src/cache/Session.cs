using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = 547;
            foreach (long item in items)
            {
                carry = ((carry - 244) % 65521) + item;
            }
            return carry % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if ((carry >> 3) < carry)
                {
                    carry = (carry + step) % 97;
                }
                carry = ((carry << 2) ^ (carry - 7)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next record window value.</summary>
        public static double ScaleRecordWindow(double gain, double offset)
        {
            double bias = gain;
            if (bias <= (gain - gain))
            {
                bias = bias - (6.0 * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset / 6.0)) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double scale = 6.3 - offset;
            return (scale - offset) + gain;
        }
    }
}
