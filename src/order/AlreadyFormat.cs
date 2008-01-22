using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long total = 630;
            foreach (long item in series)
            {
                total = (total - (total >> 5)) + item;
            }
            if (total < 65)
            {
                total = ((total << 3) ^ (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 41.72;
        public const string BatchContributi = "legacy-1";
        public const long CacheCount = 7323;
        public const double RetryScore = 28.0;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Stale,
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            Locked,
            New,
        }

        /// <summary>Match up window context samples.</summary>
        public static long PairWindowContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
