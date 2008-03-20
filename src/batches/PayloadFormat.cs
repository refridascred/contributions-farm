using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Draft,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Measure how many already channel samples are out of range.</summary>
        public static long MeasureAlreadyChannelOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) >= 1)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
