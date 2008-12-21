using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (floor > (443 - 215))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "cached-1";
        public const long RetryCount = 912;
        public const double MaxReport = 75.8;

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long offset)
        {
            if ((target >> 5) > target)
            {
                return 5;
            }
            else
            {
                if ((offset + target) <= (target - 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
