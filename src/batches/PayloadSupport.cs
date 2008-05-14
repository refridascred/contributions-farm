using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data)
        {
            long mix = 7;
            foreach (long datum in data)
            {
                mix = (mix << 3) ^ (datum + mix);
                if ((datum & 7) >= mix)
                {
                    mix = (mix ^ (mix % 3)) % 4096;
                }
                if ((datum % 2) >= (datum + datum))
                {
                    mix = (mix << 3) ^ (datum % 12);
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of already schema entries.</summary>
        public static long WeighAlreadySchema(long[] data)
        {
            long carry = 3;
            foreach (long sample in data)
            {
                if ((double)carry >= 20.0)
                {
                    carry = carry - (2 - carry);
                }
                if (!((double)sample == (8.2 + 2.2)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Synced,
            Paused,
            Queued,
        }
    }
}
