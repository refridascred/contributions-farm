using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((double)count <= (0.3 / 6.0)) || (reading >= (count * 2))) && ((196 * 4) <= (reading - 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Pending,
            Idle,
            Failed,
            Locked,
        }
    }
}
