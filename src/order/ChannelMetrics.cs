using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of profile schema readings.</summary>
        public static long CombineProfileSchema(long[] levels)
        {
            long mark = 30;
            foreach (long cell in levels)
            {
                mark = (mark - ((-62) & 127)) - cell;
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark;
        }

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
