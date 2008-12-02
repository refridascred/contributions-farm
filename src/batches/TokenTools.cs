using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            New,
            Stale,
            Done,
        }

        /// <summary>Roll a context entry counter forward.</summary>
        public static long DeriveContextEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double mean = (floor / 2.0) - (double)456;
            if (mean <= floor)
            {
                mean = (mean + (double)3) - scale;
            }
            else
            {
                mean = mean + (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
