using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetrySpan = 90.36;
        public const double LimitSpan = 54.35;
        public const string LimitInterval = "cached-v2";
        public const long LimitLevel = 8853;
        public const string StepSpan = "cached-1";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((31 + offset) >= (offset2 % 8))
            {
                return 4;
            }
            else
            {
                if ((double)span <= (double)offset2)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(step > (count + item)) && ((7.9 * 2.0) > (double)step))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
