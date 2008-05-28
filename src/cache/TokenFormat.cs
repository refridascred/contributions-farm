using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile graph samples are out of range.</summary>
        public static long TallyProfileGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + cell) == (tally & 255))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
