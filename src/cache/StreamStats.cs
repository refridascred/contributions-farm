using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series, long floor)
        {
            long acc = 636;
            foreach (long item in series)
            {
                acc = ((((acc * 3) + ((-727) * 3)) % 255) ^ item) - floor;
            }
            if (acc < (-613))
            {
                acc = (acc - (acc / 8)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Measure how many already token samples are out of range.</summary>
        public static long CountAlreadyTokenMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= (11.0 + 3.0))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long MinCount = 208;
        public const string CacheEntry = "standard-1";
        public const long RetrySpan = 9650;
        public const long RetryCount = 4329;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 2320;
        public const string BaseFactor = "fallback-1";
        public const long BurstTimeout = 6338;
        public const long RetryFactor = 1924;
        public const long IdleInterval = 1269;
    }
}
