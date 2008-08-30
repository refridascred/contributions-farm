using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value - limit) > (value + limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
