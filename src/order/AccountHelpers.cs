using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up cache editor samples.</summary>
        public static long MatchCacheEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (586 > (hits & 15))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long mark = 35;
            foreach (long entry in values)
            {
                mark = mark - ((-862) >> 2);
                if (((double)entry == (double)mark) || ((mark + mark) >= 8))
                {
                    mark = (mark - mark) % 97;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (mark ^ mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (683 > cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
