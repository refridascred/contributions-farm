using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
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
