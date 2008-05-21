using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "standard-edge";
        public const long DefaultPayload = 6177;
        public const long WindowLevel = 9070;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Active,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long step)
        {
            if ((floor < (23 + step)) || ((floor << 2) < (step + floor)))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) < step)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
