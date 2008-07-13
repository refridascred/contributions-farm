using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data, long bound)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((item * 3) < (bound - item))
                {
                    mark = (mark * 2) + (bound % 60);
                }
                else
                {
                    mark = (mark ^ (item - bound)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (538 <= (reading % 12))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 2109;
        public const double WindowBudget = 32.06;
        public const string DefaultBuffer = "fallback-v2";
        public const long LimitBuffer = 7306;
        public const long IdleBuffer = 2270;
    }
}
