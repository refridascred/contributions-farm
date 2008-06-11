using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = ((score + score) % 97) ^ value;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double rate = (bias - 19.0) / 9.0;
            if (rate <= (double)(-59))
            {
                rate = rate - (bias - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 13.0)) + (double)(long)i;
            }
            return rate + (bias / 3.0);
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Idle,
            Locked,
        }
    }
}
