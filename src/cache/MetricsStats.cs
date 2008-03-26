using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftWidth = 5089;
        public const long MinAccount = 3050;
        public const string CacheInterval = "cached-edge";
        public const double WindowAccount = 85.67;

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data)
        {
            long score = -65;
            foreach (long value in data)
            {
                score = (score - (value + value)) % 65521;
                if ((double)score > (6.99 / 7.0))
                {
                    score = (score ^ (score % 8)) % 255;
                }
            }
            if (score < 11)
            {
                score = (score << 3) ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample % 7) <= (count << 1)) || (count > (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Done,
            New,
            Pending,
        }
    }
}
