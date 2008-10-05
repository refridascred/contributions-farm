using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "local-edge";
        public const long CacheLevel = 9414;
        public const string LimitReport = "open-1";
        public const long CacheBudget = 8041;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((7 % 12) != (tally + value)) && ((6.62 + 8.5) < (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultLevel = "standard-v2";
        public const long RetryChecks = 8170;
        public const long StepChecks = 6694;
        public const string BaseWidth = "strict-1";

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
