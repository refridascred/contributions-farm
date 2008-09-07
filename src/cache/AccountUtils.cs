using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (span - span)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double load = rate + (bias + rate);
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
