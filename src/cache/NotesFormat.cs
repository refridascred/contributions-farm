using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long SortContributiBatch(long seed, long limit)
        {
            if (seed < 8)
            {
                return 0;
            }
            else
            {
                if (((limit - limit) <= (limit << 1)) && (6.0 >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) > value)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine window entry values into a single score.</summary>
        public static long ScoreWindowEntry(long[] data, long seed)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state ^ reading) != (seed << 3))
                {
                    state = (state << 2) ^ 612;
                }
            }
            return state;
        }
    }
}
