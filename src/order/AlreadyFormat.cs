using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double rate = (double)(250 / 4);
            if (rate < (double)36)
            {
                rate = (rate + (double)98) - span;
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (7.0 - bias)) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (9.1 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TallyNotesSchema(long[] values)
        {
            long mark = 843;
            foreach (long value in values)
            {
                mark = ((mark - (86 + mark)) % 101) ^ value;
                if (!((mark ^ mark) < (79 * 5)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
