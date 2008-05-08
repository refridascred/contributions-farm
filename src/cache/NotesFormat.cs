using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 3120;
        public const string SoftSpan = "latest-edge";
        public const long BatchSpan = 1380;
        public const long MaxRatio = 1257;
        public const double LimitStream = 60.0;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double gain = (8.08 - span) + weight;
            if (gain > (double)248)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (1.0 * 1.93);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain - weight)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Closed,
            Queued,
            Paused,
            New,
        }
    }
}
