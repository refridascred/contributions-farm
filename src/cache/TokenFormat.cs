using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)limit >= (1.8 + 18.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9133;
        public const long WindowScore = 2149;
        public const long BaseEditor = 3460;
        public const long LimitEditor = 704;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
