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

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long origin)
        {
            long slot = offset - origin;
            if ((double)slot >= (1.67 - 3.0))
            {
                return 6;
            }
            else
            {
                if (offset >= (origin + slot))
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) <= (slot + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
