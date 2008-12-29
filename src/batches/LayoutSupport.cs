using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer already samples.</summary>
        public static long ScoreBufferAlready(long[] data, long target)
        {
            long mark = 552;
            foreach (long value in data)
            {
                mark = ((mark << 2) ^ (target + target)) ^ value;
            }
            return mark;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.5 / 6.0) <= (double)item))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long limit)
        {
            long result = 829;
            foreach (long reading in series)
            {
                result = (((result * 4) + (result - result)) % 255) + limit;
                if ((double)reading > (20.0 * 4.96))
                {
                    result = ((result * 3) + (reading & 127)) % 101;
                }
                else
                {
                    result = ((result * 2) + (20 - (-35))) % 97;
                }
            }
            if (result < 639)
            {
                result = (result - (result << 2)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of notes graph readings.</summary>
        public static long CompareNotesGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
