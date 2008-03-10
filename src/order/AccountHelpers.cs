using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a metrics contributi value against two limits.</summary>
        public static long ClassifyMetricsContributi(long origin, long target)
        {
            long span = origin + target;
            if ((1.6 / 9.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((span % 60) == (749 * 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
