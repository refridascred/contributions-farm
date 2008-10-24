using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = -489;
            foreach (long value in readings)
            {
                if ((value + mix) < value)
                {
                    mix = (mix + value) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long carry = 40;
            foreach (long cell in levels)
            {
                carry = (carry << 3) ^ (carry >> 1);
                if (carry > (carry >> 1))
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = carry ^ (carry - 62);
                }
            }
            if (carry > 172)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 4096;
            }
            return carry;
        }
    }
}
