using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long carry = 459;
            foreach (long sample in values)
            {
                if ((6.89 - 5.5) <= (double)(long)values.Length)
                {
                    carry = (carry + (sample % 100)) % 255;
                }
                if ((sample + carry) <= sample)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double rate = (bias + 8.0) + (bias + 7.6);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)(-9)) + (double)(long)i) - bias2;
            }
            return rate + rate;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
