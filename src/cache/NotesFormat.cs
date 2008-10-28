using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "strict-1";
        public const long WindowInterval = 3079;
        public const string IdleScore = "cached";
        public const double RetryRecord = 22.23;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double drift = 0.45;
            if (drift >= (double)4)
            {
                drift = (drift - bias) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + 2.8;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double offset)
        {
            double bias2 = (double)(383 / 4);
            if (bias2 < (bias * 0.3))
            {
                bias2 = bias2 - (1.0 / 7.0);
            }
            else
            {
                bias2 = bias2 + (bias + bias2);
            }
            return bias2 - (bias - offset);
        }
    }
}
