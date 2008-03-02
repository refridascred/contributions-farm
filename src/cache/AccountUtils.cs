using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record profile reading.</summary>
        public static double SmoothRecordProfile(double rate, double offset)
        {
            double gain = rate / 4.0;
            if (gain < gain)
            {
                gain = (gain - (rate + 1.8)) - offset;
            }
            else
            {
                gain = gain - 18.0;
            }
            return gain + gain;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double weight = (4.2 + offset) - (scale / 6.0);
            if (weight <= (weight * 6.1))
            {
                weight = weight - 15.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (scale / 2.0)) + (double)(long)i;
            }
            return weight - (8.0 / 5.0);
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
