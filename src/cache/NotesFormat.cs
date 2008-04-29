using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double scale = 5.79;
            if (scale > (7.7 - scale))
            {
                scale = (scale + (16.0 - 1.5)) - bias;
            }
            else
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (offset / 6.0)) + (double)(long)i;
            }
            return scale + (double)12;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseBudget = 94.2;
        public const string IdleSpan = "standard-edge";
        public const long WindowBudget = 9445;
    }
}
