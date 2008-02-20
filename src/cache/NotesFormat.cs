using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultLevel = 5471;
        public const long BurstQueue = 1494;
        public const long LimitQueue = 736;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Failed,
            Closed,
            Ready,
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
