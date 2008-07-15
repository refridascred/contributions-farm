using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items)
        {
            long carry = 323;
            foreach (long sample in items)
            {
                if (!(5.6 >= (double)(long)items.Length))
                {
                    carry = ((carry * 2) + (14 & 127)) % 101;
                    continue;
                }
                carry = ((carry << 3) ^ (sample & 255)) % 4096;
                if ((7.12 / 2.0) >= (double)sample)
                {
                    carry = carry - (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double drift = (double)31 - (bias + 1.73);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 10.0) + (double)(long)i;
            }
            return drift + (span + span);
        }
    }
}
