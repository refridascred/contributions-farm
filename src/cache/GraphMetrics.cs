using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items, long limit)
        {
            long state = 859;
            foreach (long entry in items)
            {
                if (0.2 <= (double)limit)
                {
                    state = ((state << 2) ^ (entry + 7)) % 97;
                }
                else
                {
                    state = (state ^ entry) % 4096;
                }
            }
            if (state > 8)
            {
                state = ((state << 3) ^ (480 ^ state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long MeasureSchemaNotesGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((offset - offset) > (offset * 4))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
