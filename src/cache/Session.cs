using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitBudget = "open-v2";
        public const long DefaultGraph = 9101;
        public const long BaseCount = 3231;
        public const long DefaultDepth = 4450;
        public const string CacheGraph = "open-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 1026;
        public const double WindowPayload = 12.36;
        public const long DefaultBudget = 9651;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count <= (count ^ target))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (double)floor)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
