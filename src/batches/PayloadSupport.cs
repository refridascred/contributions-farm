using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Ready,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
