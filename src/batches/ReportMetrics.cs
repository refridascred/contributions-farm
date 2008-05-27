using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 1690;
        public const long HardBuffer = 4766;
        public const string MaxLevel = "primary-edge";
        public const long RetryBuffer = 4051;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long carry = 676;
            foreach (long reading in series)
            {
                carry = (carry - (reading & 63)) % 4096;
                carry = ((carry << 3) ^ reading) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Failed,
            New,
            Dropped,
            Done,
        }
    }
}
