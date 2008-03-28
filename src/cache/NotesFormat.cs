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

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (long)i) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
