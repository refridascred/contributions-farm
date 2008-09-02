using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double drift = (double)(8 + 0);
            if (drift < (bias - bias))
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift + (ratio + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (8.6 + ratio);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches * 3) == (sample % 97))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryInterval = 2697;
        public const long IdleSize = 5849;
        public const double IdleNotes = 59.31;
        public const double IdleBudget = 0.76;
    }
}
