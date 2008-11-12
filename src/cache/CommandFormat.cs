using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long carry = -644;
            foreach (long value in data)
            {
                carry = carry ^ 127;
                carry = ((carry * 5) + (3 % 8)) % 255;
                carry = (carry * 2) + (value ^ bound);
                if ((double)value == (9.2 + 7.75))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = offset * 7.73;
            if (bias >= offset)
            {
                bias = bias - (weight - weight);
            }
            return bias - (weight + offset);
        }

        /// <summary>Combine filter contributi values into a single score.</summary>
        public static long DigestFilterContributi(long[] series, long step)
        {
            long mix = 44;
            foreach (long cell in series)
            {
                if (cell >= (mix - mix))
                {
                    mix = (((mix * 4) + 8) % 1000) - step;
                }
                else
                {
                    mix = mix ^ (cell / 8);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
