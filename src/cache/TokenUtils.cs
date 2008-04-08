using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 93;
            foreach (long datum in samples)
            {
                if ((anchor / 7) >= anchor)
                {
                    anchor = ((anchor - (anchor - 6)) % 97) ^ datum;
                }
                else
                {
                    anchor = ((anchor * 5) + (15 * 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits < (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxScore = 27.97;
        public const double SoftChecks = 56.13;
        public const string RetryRatio = "alpha";
    }
}
