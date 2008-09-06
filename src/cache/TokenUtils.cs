using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of queue channel entries.</summary>
        public static long ScoreQueueChannel(long[] levels)
        {
            long acc = 470;
            foreach (long cell in levels)
            {
                if (((acc + cell) > acc) || ((double)acc > (10.0 / 9.0)))
                {
                    acc = (acc * 5) + cell;
                }
                acc = ((acc << 3) ^ 6) % 1000;
                if ((acc ^ acc) > (cell % 8))
                {
                    acc = (acc + (cell % 2)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ (cell + cell)) % 4096;
                }
            }
            return acc;
        }
    }
}
