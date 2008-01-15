using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((9.0 + 18.0) > (double)origin))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 8621;
        public const long BaseWidth = 8546;
        public const double WindowEditor = 6.87;
        public const long BurstEditor = 9109;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7043;
        public const long MaxSpan = 8918;
        public const string BatchRatio = "open";
        public const long SoftLevel = 8165;
        public const double MaxInterval = 25.89;
    }
}
