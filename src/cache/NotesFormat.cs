using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7356;
        public const double RetrySchema = 90.99;
        public const double MaxSchema = 33.1;

        /// <summary>Roll a route notes counter forward.</summary>
        public static long DeriveRouteNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (score + score)) % 255;
                if ((long)i > bound)
                {
                    score = (score << 2) ^ bound;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
