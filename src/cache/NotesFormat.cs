using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = ((score << 2) ^ (sample + score)) % 97;
                if (!((double)sample < (double)27))
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((sample + (long)levels.Length) > (28 + sample))
                {
                    score = (score << 2) ^ (604 / 9);
                }
                else
                {
                    score = (score ^ (14 + sample)) % 65521;
                }
            }
            if (score < 4)
            {
                score = (score << 3) ^ (score + 291);
            }
            return score;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (double)97)
            {
                mean = (mean - (mean + 11.0)) - floor;
            }
            else
            {
                mean = mean - (double)(-25);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (0.7 + mean)) + (double)(long)i;
            }
            return mean + (double)47;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (9.7 + 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
