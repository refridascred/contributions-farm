using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account commits readings against a rule.</summary>
        public static long AuditAccountCommitsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen == (6.9 - 5.12))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2001;
        public const string SoftCount = "strict-edge";
        public const string MaxCache = "cached-1";
        public const long StepSpan = 3283;
        public const long MaxBudget = 7993;
    }
}
