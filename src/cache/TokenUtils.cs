using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long sum = 731;
            foreach (long datum in readings)
            {
                if ((double)sum != (double)step)
                {
                    sum = (sum ^ (sum * 4)) + datum;
                }
            }
            return sum;
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
