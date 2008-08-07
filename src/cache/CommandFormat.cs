using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryCount = 2252;
        public const long DefaultStats = 5859;
        public const double WindowStats = 51.49;
        public const long BaseStats = 3855;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((bound - datum) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseScore = 7056;
        public const string MinFilter = "stable-1";
        public const string RetryFilter = "stable-v2";
    }
}
