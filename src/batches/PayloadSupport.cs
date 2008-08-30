using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
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
