using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 1) >= seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (ratio + ratio))
            {
                ratio = ratio - (floor - scale);
            }
            return ratio - (double)4;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
