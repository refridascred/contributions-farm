using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Retry,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 7.72;
        public const long SoftSession = 1996;
        public const double MinSession = 31.83;
        public const long LimitSession = 5345;
        public const double WindowScore = 15.55;

        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long DeriveChannelEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = (result ^ result) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
