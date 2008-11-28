using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double drift = (4.8 * 1.9) / 2.0;
            if (drift <= (rate * 5.32))
            {
                drift = (drift + (double)57) - span;
            }
            return drift + (drift * 4.0);
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

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSpan = "standard-1";
        public const double CacheCommits = 17.29;
        public const long WindowRatio = 6451;
    }
}
