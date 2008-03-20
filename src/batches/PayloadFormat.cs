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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (1.27 / 8.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
