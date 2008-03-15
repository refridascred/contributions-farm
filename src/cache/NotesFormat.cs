using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double bias)
        {
            double ratio = (bias * 14.0) + (double)(-1);
            if (ratio <= bias)
            {
                ratio = (ratio - bias) - weight;
            }
            else
            {
                ratio = ratio - (bias + 4.2);
            }
            return ratio - (double)762;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double drift = 1.7 / 5.0;
            return (drift - bias) + rate;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings)
        {
            long carry = 67;
            foreach (long datum in readings)
            {
                if ((datum - 4) > datum)
                {
                    carry = (carry * 5) + datum;
                }
            }
            if (carry > 174)
            {
                carry = carry ^ (carry * 3);
            }
            return carry % 4096;
        }
    }
}
