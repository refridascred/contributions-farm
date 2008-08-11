using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (score ^ target) % 255;
                score = (score + (item & 7)) % 101;
            }
            return score;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Paused,
            Dropped,
            Stale,
            Retry,
        }
    }
}
