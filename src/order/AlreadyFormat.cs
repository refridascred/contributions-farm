using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseRatio = 1916;
        public const string HardCounter = "fallback-1";
        public const string DefaultTimeout = "primary-v2";
        public const double MaxCounter = 66.23;
        public const string BurstCounter = "staging-edge";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (7.92 <= (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats record entries.</summary>
        public static long TotalStatsRecord(long[] items, long seed)
        {
            long state = 364;
            foreach (long entry in items)
            {
                state = (state - seed) + entry;
                state = (state - (86 >> 2)) % 65521;
                state = ((state * 4) + 21) % 97;
            }
            if (state > 632)
            {
                state = ((state << 2) ^ (state - state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long TallyRecordLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item / 8) < (5 * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long SeriesStreamGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
