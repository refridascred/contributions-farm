using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                if ((carry << 1) <= step)
                {
                    carry = ((carry << 2) ^ (step + carry)) % 4096;
                }
                else
                {
                    carry = (carry + item) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Dropped,
            Retry,
        }
    }
}
