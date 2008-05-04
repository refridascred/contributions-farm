using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double weight = (9.0 * 5.23) + scale;
            if (weight <= scale)
            {
                weight = weight - offset;
            }
            return weight + (scale + scale);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 5186;
        public const long WindowScore = 2327;
        public const string CacheTimeout = "strict-edge";
        public const long BatchContext = 4749;
        public const long IdleBudget = 8725;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((1.0 - 16.0) <= (double)origin)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSpan = "alpha";
        public const long WindowInterval = 3988;
        public const long DefaultSchema = 4953;
        public const string MaxFactor = "fallback-1";
    }
}
