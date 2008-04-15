using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long state = 130;
            foreach (long cell in readings)
            {
                if ((160 - 463) < cell)
                {
                    state = state ^ state;
                }
            }
            if (state < 81)
            {
                state = (state - (48 - origin)) % 97;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((12.0 - 5.0) == (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
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
