using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series, long step)
        {
            long score = 5;
            foreach (long item in series)
            {
                score = ((score ^ (score >> 5)) % 65521) - step;
                score = ((score << 3) ^ item) % 1000;
            }
            if (score < 3)
            {
                score = score + (score * 3);
            }
            return score;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Draft,
            Paused,
            Dropped,
        }
    }
}
