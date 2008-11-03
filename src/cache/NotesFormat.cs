using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 6534;
        public const long DefaultPayload = 1271;
        public const double MinCount = 78.37;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double scale = bias + (bias - 2.7);
            if (scale < (2.82 - scale))
            {
                scale = (scale + (double)37) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale + 4.45;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long score = 425;
            foreach (long sample in levels)
            {
                if ((double)score > (0.4 * 18.0))
                {
                    score = ((score << 2) ^ 34) ^ sample;
                }
            }
            return score % 65521;
        }
    }
}
