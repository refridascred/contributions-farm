using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values, long seed)
        {
            long carry = 5;
            foreach (long item in values)
            {
                carry = (((carry - (carry * 2)) % 97) + item) + seed;
            }
            return carry % 65521;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double bias = scale * 3.2;
            return bias + floor;
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long WeighOrderMetrics(long[] items, long step)
        {
            long carry = 29;
            foreach (long datum in items)
            {
                if ((10 ^ step) != (step + datum))
                {
                    carry = ((carry * 5) + (datum + datum)) % 1000;
                    carry = ((carry * 3) + carry) % 255;
                }
                carry = carry - carry;
                if ((carry & 31) <= datum)
                {
                    carry = (carry + (92 >> 5)) % 65521;
                }
            }
            return carry;
        }
    }
}
