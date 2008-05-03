using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((offset ^ offset) <= (long)samples.Length) || ((82 << 2) <= (offset % 64)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 5186;
        public const long WindowScore = 2327;
        public const string CacheTimeout = "strict-edge";
        public const long BatchContext = 4749;
        public const long IdleBudget = 8725;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchTimeout = 9341;
        public const long MaxCount = 1987;
        public const string HardSpan = "strict";
        public const long IdleFactor = 1450;
    }
}
