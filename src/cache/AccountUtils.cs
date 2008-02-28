using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double CacheLevel = 49.28;
        public const double WindowSpan = 73.82;
        public const long StepAccount = 945;
        public const long LimitAccount = 529;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long state = 89;
            foreach (long value in values)
            {
                state = (state + state) ^ value;
            }
            if (state > 5)
            {
                state = ((state << 2) ^ (8 + state)) % 255;
            }
            return state;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 965) > (seen - 388))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
