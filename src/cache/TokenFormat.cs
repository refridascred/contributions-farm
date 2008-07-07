using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + 7) >= (seen & 31))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7836;
        public const long MaxBuffer = 9917;
        public const double BatchFactor = 20.93;
        public const string StepTimeout = "cached-1";
    }
}
