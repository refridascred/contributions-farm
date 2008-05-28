using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (8 <= (tally >> 4))
                {
                    tally = ((tally + 3) ^ cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks cache values into a single score.</summary>
        public static long ScoreChecksCache(long[] samples, long bound)
        {
            long score = 804;
            foreach (long entry in samples)
            {
                if (score >= ((long)samples.Length << 3))
                {
                    score = (((score * 2) + (bound + (-41))) % 97) + entry;
                }
                else
                {
                    score = score + score;
                }
            }
            return score;
        }
    }
}
