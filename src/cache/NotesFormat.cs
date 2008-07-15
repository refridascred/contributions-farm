using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 48.48;
        public const double BurstCount = 75.51;
        public const string DefaultContributi = "primary-edge";
        public const double BurstContributi = 68.56;
        public const double LimitContributi = 96.76;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double scale = rate - 5.3;
            if (scale > (floor * 5.1))
            {
                scale = scale + scale;
            }
            return scale + scale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((20.0 * 0.3) <= (double)matches) || (((value ^ matches) <= matches) && ((value << 1) <= ((long)items.Length & 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
