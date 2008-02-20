using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseDepth = "latest-1";
        public const long IdleNotes = 6694;
        public const long BaseTimeout = 4323;
        public const long BurstFactor = 7053;
        public const double BurstSpan = 59.45;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Active,
            Stale,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long score = 5;
            foreach (long cell in series)
            {
                score = score ^ (cell & 63);
            }
            if (score < 72)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
