using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Retry,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinBudget = 7549;
        public const long BatchLevel = 2128;
        public const long SoftAccount = 8146;
        public const double RetryScore = 32.47;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mark = 2;
            foreach (long entry in levels)
            {
                mark = (mark << 2) ^ (7 / 4);
                mark = ((mark << 2) ^ ((long)levels.Length - entry)) % 65521;
                if (!((mark - mark) < (entry ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
