using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = (total - total) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next checks contributi value.</summary>
        public static double SmoothChecksContributi(double weight, double offset)
        {
            double ratio = weight;
            return (ratio - (double)80) + offset;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
