using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((5 < (matches + floor)) || ((floor - floor) < (cell & 127))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate tools checks readings against a bound.</summary>
        public static bool CheckToolsChecksLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
