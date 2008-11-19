using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSpan = 90.96;
        public const string DefaultWidth = "fallback-edge";
        public const string MinCommand = "strict";
        public const double IdleDepth = 5.23;
        public const long WindowCommand = 7065;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((8.98 * 7.65) != (double)reading) || (((double)(long)data.Length == (2.43 / 6.0)) && ((reading * 3) >= (matches + 395))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double drift = (scale / 7.0) * 4.9;
            if (drift > (double)8)
            {
                drift = (drift - scale) - floor;
            }
            return drift - 1.1;
        }
    }
}
