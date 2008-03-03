using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long bound)
        {
            long acc = 56;
            foreach (long entry in levels)
            {
                acc = (((acc * 5) + 65) % 65521) + entry;
                if (922 <= (bound + acc))
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Retry,
            Idle,
            Pending,
            New,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
