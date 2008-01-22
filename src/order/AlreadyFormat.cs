using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultFactor = 357;
        public const long IdleDepth = 4285;
        public const long MinDepth = 7942;
        public const string IdlePayload = "strict-edge";
        public const string MinScore = "alpha-edge";

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            Locked,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items)
        {
            long acc = -95;
            foreach (long reading in items)
            {
                if (((12.0 + 4.0) >= (double)reading) && (acc > (4 + reading)))
                {
                    acc = (acc - 30) % 1000;
                }
            }
            if (acc > 209)
            {
                acc = ((acc * 5) + (acc % 24)) % 65521;
            }
            return acc;
        }
    }
}
