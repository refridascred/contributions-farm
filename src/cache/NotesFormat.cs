using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 7929;
        public const long StepSupport = 8518;
        public const long MaxSupport = 35;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double rate = (weight - offset) + weight;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)4) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double scale = (double)(50 % 2);
            if (scale > (scale / 7.0))
            {
                scale = (scale + (bias * 8.1)) - ratio;
            }
            else
            {
                scale = scale + (scale / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)71;
        }
    }
}
