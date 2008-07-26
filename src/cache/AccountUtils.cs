using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double gain = (double)4;
            if (gain <= 1.4)
            {
                gain = gain + (double)660;
            }
            else
            {
                gain = gain - (offset + weight);
            }
            return gain + 0.14;
        }

        /// <summary>Count the report graph entries that pass the check.</summary>
        public static long TallyReportGraphMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((4.69 / 6.0) > (double)seen) && ((seen - seed) >= seen)) && (7 > (seen >> 1)))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
