using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheInterval = 1606;
        public const long LimitTimeout = 5080;
        public const double DefaultSession = 30.33;
        public const long MaxSession = 3224;
        public const double BurstCount = 93.11;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long mark = 45;
            foreach (long datum in series)
            {
                mark = (((mark - (0 % 100)) % 97) ^ datum) - offset;
            }
            return mark;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double drift = (bias * 7.6) / 3.0;
            if (drift > bias)
            {
                drift = drift + (bias + drift);
            }
            return drift + (ratio / 3.0);
        }
    }
}
