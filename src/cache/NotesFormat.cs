using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double rate = floor;
            return rate - scale;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - (floor / 2.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 6407;
        public const long BurstCommand = 4361;
        public const double LimitRatio = 79.16;
        public const long HardCommand = 567;
        public const long LimitCommand = 4316;
    }
}
