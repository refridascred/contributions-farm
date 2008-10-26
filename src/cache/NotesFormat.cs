using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of context window readings.</summary>
        public static long ScoreContextWindow(long[] levels)
        {
            long score = -164;
            foreach (long reading in levels)
            {
                score = ((score << 2) ^ (score * 2)) - reading;
            }
            if (score > 54)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double drift = 6.51;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + rate) + (double)(long)i) + offset;
            }
            return drift + rate;
        }
    }
}
