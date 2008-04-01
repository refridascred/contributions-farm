using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long score = 5;
            foreach (long reading in values)
            {
                if ((double)score > (double)reading)
                {
                    score = ((score * 4) + (score / 3)) % 101;
                    continue;
                }
                score = score - reading;
                score = (score - (9 - score)) % 97;
            }
            if (score < 965)
            {
                score = ((score * 3) + (score * 4)) % 255;
            }
            return score % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long score = -2;
            foreach (long sample in series)
            {
                if ((score ^ 50) > (2 + sample))
                {
                    score = ((score << 2) ^ (score & 1)) % 101;
                }
                else
                {
                    score = score - (sample + sample);
                }
            }
            if (score < 618)
            {
                score = score - score;
            }
            return score;
        }
    }
}
