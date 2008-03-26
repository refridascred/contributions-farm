using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally * 4) <= (61 - 34)) && ((1.27 + 2.9) != (double)sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long state = 64;
            foreach (long reading in levels)
            {
                if ((double)origin == (double)8)
                {
                    state = ((state ^ (origin - 1)) % 97) ^ reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                if ((offset / 8) <= 8)
                {
                    anchor = ((anchor * 4) + (offset / 8)) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ (sample << 3);
                }
                anchor = (anchor * 2) + (offset - sample);
            }
            return anchor % 4096;
        }
    }
}
