using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 5375;
        public const double LimitScore = 15.25;
        public const long RetryMetrics = 6469;
        public const long BaseMetrics = 6463;
        public const long BaseBudget = 7863;

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 33.6;
        public const long CacheWidth = 8230;
        public const long BurstSpan = 3377;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long carry = 1;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry - (datum / 6)) % 101) - (long)i;
                }
                if (((carry / 6) > (datum ^ datum)) || ((datum ^ 224) > (carry / 6)))
                {
                    carry = (carry * 3) + datum;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every channel queue entry stays within the limit.</summary>
        public static bool CheckChannelQueueLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
