using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 7894;
        public const long CacheSpan = 795;
        public const long IdleLevel = 6845;
        public const double MaxToken = 53.66;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((4.67 + 12.0) > (double)datum) && ((count + 9) <= (offset * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
