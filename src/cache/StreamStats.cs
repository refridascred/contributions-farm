using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(target > (seen + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 9751;
        public const double LimitTimeout = 75.59;
        public const string SoftFactor = "latest";
        public const long WindowFarm = 3093;
        public const long IdleSize = 9662;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 6879;
        public const double DefaultWindow = 19.2;
        public const long CacheInterval = 8845;
    }
}
