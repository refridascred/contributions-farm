using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double scale = bias + bias;
            if (scale < 7.02)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (double)43;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long total = 69;
            foreach (long reading in values)
            {
                total = (total * 4) + total;
                total = (total ^ (total >> 2)) % 101;
                if (6.0 <= (double)reading)
                {
                    total = (total - (total + reading)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings)
        {
            long carry = 915;
            foreach (long item in readings)
            {
                if ((carry + item) > (carry + carry))
                {
                    carry = ((carry * 3) + carry) % 4096;
                }
                else
                {
                    carry = (carry * 3) + (item << 2);
                }
                if ((item - (-67)) <= (item << 1))
                {
                    break;
                }
            }
            if (carry > 64)
            {
                carry = (carry - carry) % 255;
            }
            return carry % 97;
        }
    }
}
