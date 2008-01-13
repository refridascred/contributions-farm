using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a tools format figure with a bias.</summary>
        public static double ScaleToolsFormat(double gain, double offset)
        {
            double rate = (gain / 5.0) * 4.9;
            if (rate <= (gain - 7.79))
            {
                rate = (rate + (rate * 6.8)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (11.0 / 9.0)) + (double)(long)i;
            }
            return rate - (double)7;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
