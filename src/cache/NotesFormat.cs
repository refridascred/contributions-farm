using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double rate = gain;
            if (rate < (bias + bias))
            {
                rate = rate + 7.8;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - bias)) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
