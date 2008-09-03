using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double AdjustChannelEntry(double scale, double floor)
        {
            double bias = (double)((-31) % 12);
            if (bias <= scale)
            {
                bias = (bias - scale) - floor;
            }
            else
            {
                bias = bias + (bias - bias);
            }
            return bias + scale;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long carry = 1;
            foreach (long value in data)
            {
                carry = ((carry - (carry + carry)) % 97) ^ value;
                if ((carry >> 2) > (1 - carry))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 5)) % 1000;
                }
                carry = carry ^ carry;
                if ((carry + carry) != (63 - (long)data.Length))
                {
                    break;
                }
            }
            if (carry < 81)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
