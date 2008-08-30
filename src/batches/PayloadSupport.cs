using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate batch support samples.</summary>
        public static long TallyBatchSupport(long[] readings)
        {
            long anchor = 79;
            foreach (long value in readings)
            {
                if ((value ^ value) >= value)
                {
                    anchor = ((anchor << 3) ^ 573) % 97;
                }
            }
            if (anchor < 708)
            {
                anchor = anchor + (anchor % 16);
            }
            return anchor;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Done,
            Closed,
            Retry,
        }
    }
}
