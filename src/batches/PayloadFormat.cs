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

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 54.86;
        public const long LimitReport = 3868;
        public const long IdleCount = 768;
        public const double BaseReport = 35.32;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Draft,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= (4.5 * 8.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
