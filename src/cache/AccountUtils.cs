using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry + hits) != (734 & 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinLevel = 4751;
        public const long BaseCount = 4916;
        public const long MinSpan = 5806;
        public const long LimitInterval = 514;
        public const long RetryRatio = 2235;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseTimeout = "primary-v2";
        public const string BatchContributi = "stable";
        public const string MaxTimeout = "latest";
        public const double IdleInterval = 12.03;
    }
}
