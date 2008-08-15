using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            New,
            Retry,
            Draft,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long TallySchemaFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((851 + 2) > (matches << 3))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
