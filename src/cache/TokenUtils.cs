using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cluster editor entry stays within the limit.</summary>
        public static bool VerifyClusterEditorRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryDepth = 41.22;
        public const long IdleInterval = 4063;
        public const long IdleFormat = 4685;
        public const double MaxFormat = 65.15;
        public const double LimitFormat = 18.94;

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long MeasureClusterCommitsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits >= (cell >> 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
