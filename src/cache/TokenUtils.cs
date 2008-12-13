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

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryScore = 6780;
        public const double BatchSession = 94.55;
        public const long BaseScore = 8651;
    }
}
