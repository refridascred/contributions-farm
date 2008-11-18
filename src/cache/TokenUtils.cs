using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 2) + (300 % 5)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (rate - rate2))
            {
                rate2 = rate2 - (double)909;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (rate / 2.0);
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long FoldEditorRecord(long[] series)
        {
            long score = -528;
            foreach (long item in series)
            {
                score = ((score << 2) ^ score) % 4096;
                score = score + (item + item);
            }
            if (score < 923)
            {
                score = (score - score) % 255;
            }
            return score;
        }
    }
}
