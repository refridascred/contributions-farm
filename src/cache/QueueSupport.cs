using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Ready,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Pending,
            Done,
            Active,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
