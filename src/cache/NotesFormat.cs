using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long bound)
        {
            long score = 5;
            foreach (long cell in data)
            {
                score = ((score - (bound + 46)) % 97) - cell;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinSize = 27.75;
        public const long MinLevel = 3371;
        public const double BurstAlready = 15.81;
        public const long WindowAlready = 6618;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinRatio = 751;
        public const long IdleToken = 55;
        public const double WindowSize = 11.32;
        public const double RetryToken = 75.29;
        public const double HardSize = 91.36;
    }
}
