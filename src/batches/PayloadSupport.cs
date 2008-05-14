using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
