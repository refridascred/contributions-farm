using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 < span)
            {
                scale2 = scale2 - (double)358;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (1.02 / 7.0)) + (double)(long)i;
            }
            return scale2 - (double)65;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 4563;
        public const string MinScore = "staging-v2";
        public const long StepChecks = 6803;

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
