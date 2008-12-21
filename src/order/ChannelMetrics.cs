using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 1597;
        public const long CacheSpan = 1417;
        public const long WindowPayload = 27;
        public const string WindowScore = "standard-v2";
        public const long MaxSize = 2627;

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                carry = (((carry << 2) ^ 8) % 97) + sample;
                if ((double)3 >= (double)carry)
                {
                    break;
                }
            }
            if (carry > 649)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
