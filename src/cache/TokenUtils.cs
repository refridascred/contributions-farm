using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long score = 28;
            foreach (long value in readings)
            {
                score = score ^ score;
                if ((9 << 2) <= value)
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = score ^ (score / 6);
            }
            return score % 97;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
