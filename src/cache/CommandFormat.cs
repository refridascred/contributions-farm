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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Stale,
            Retry,
        }

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
