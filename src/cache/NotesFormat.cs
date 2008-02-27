using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a token stream figure with a bias.</summary>
        public static double BlendTokenStream(double scale, double floor)
        {
            double bias = floor + (double)10;
            if (bias < (floor + 8.91))
            {
                bias = (bias + bias) + scale;
            }
            else
            {
                bias = bias - (double)(-192);
            }
            return bias - floor;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - (floor * 5.73);
            }
            else
            {
                rate = rate + (ratio * 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - floor) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 2254;
        public const double IdleRatio = 24.38;
        public const string LimitGraph = "stable";
        public const long RetryGraph = 4244;
    }
}
