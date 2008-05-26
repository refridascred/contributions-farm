using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
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
