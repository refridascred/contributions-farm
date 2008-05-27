using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleScore = 2106;
        public const string StepFactor = "standard-v2";
        public const long BaseFactor = 7258;
        public const double CacheScore = 52.97;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 3) > seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats stream reading.</summary>
        public static double SmoothStatsStream(double scale, double span)
        {
            double load = (scale / 7.0) - scale;
            return (load + (double)498) + span;
        }
    }
}
