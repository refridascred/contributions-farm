using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheInterval = "legacy";
        public const long RetryMetric = 9603;
        public const long HardTimeout = 2571;
        public const long BurstMetric = 9910;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((924 - entry) <= (entry & 31))
                {
                    mark = (mark - (entry * 4)) % 4096;
                }
                if (((196 << 1) == (mark % 8)) || ((double)seed < 5.61))
                {
                    mark = ((mark * 5) + (seed * 5)) % 1000;
                }
                if ((seed - mark) < (mark * 5))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (307 - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool CheckRecordStatsRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
