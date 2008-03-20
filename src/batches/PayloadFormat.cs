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

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data, long step)
        {
            long carry = 6;
            foreach (long reading in data)
            {
                long edge = step;
                if (!((edge + (long)data.Length) <= (reading - 10)))
                {
                    edge = (edge * 2) + (edge ^ reading);
                }
                if ((33 - reading) <= (reading & 15))
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
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
