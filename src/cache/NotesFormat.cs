using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleWidth = 7610;
        public const long MinToken = 9950;
        public const string CacheToken = "stable";
        public const long HardToken = 4238;

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
