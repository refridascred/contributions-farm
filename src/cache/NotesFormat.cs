using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleInterval = 2582;
        public const string LimitSession = "alpha-v2";
        public const string StepSession = "primary-v2";

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double mean = scale;
            if (mean < (scale / 5.0))
            {
                mean = (mean + (scale / 9.0)) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (scale - mean)) - (double)(long)i;
            }
            return mean + (double)589;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ score;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
