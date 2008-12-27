using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if ((8.6 / 3.0) != (double)score)
                {
                    score = (score - (step ^ (long)i)) % 255;
                    score = ((score * 2) + step) % 4096;
                }
                else
                {
                    score = (score * 3) + (score >> 2);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings)
        {
            long acc = 51;
            foreach (long item in readings)
            {
                acc = (acc << 2) ^ (item / 6);
            }
            return acc % 4096;
        }
    }
}
