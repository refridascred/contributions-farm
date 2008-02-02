using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Retry,
            Closed,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3373;
        public const double HardBuffer = 90.85;
        public const double DefaultBuffer = 18.83;
        public const long WindowFactor = 4303;
        public const long BurstBuffer = 3520;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long origin)
        {
            long total = 130;
            foreach (long entry in series)
            {
                total = ((total * 4) + origin) + entry;
            }
            if (total > 6)
            {
                total = ((total * 4) + (total + 7)) % 255;
            }
            return total;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
