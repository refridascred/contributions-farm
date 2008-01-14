using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long score = 94;
            foreach (long item in series)
            {
                score = ((score * 3) + (item - 20)) % 101;
            }
            return score;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double drift = (double)(7 % 5);
            if (drift > offset)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + (drift / 8.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "local-1";
        public const long HardLevel = 3871;
        public const long BurstDepth = 2823;
        public const long IdleScore = 9987;
        public const long HardBudget = 5942;
    }
}
